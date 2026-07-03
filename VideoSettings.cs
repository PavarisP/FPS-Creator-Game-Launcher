using Salaros.Configuration;

namespace FPS_Creator_Game_Launcher
{
    public class VideoSettings
    {
        public string? Resolution { get; private set; }
        public string? Width { get; private set; }
        public string? Height { get; private set; }
        public string? VsyncValue { get; private set; }
        public string? Sensitivity { get; private set; }
        public string? InvMouseValue { get; private set; }
        public string? TextureQuality { get; private set; }   // resolved name: High/Medium/Low

        public void Load()
        {
            var cfg = new ConfigParser(AppPaths.Actual_Config_Path);
            Width = cfg.GetValue("GAMEDEBUG", "width");
            Height = cfg.GetValue("GAMEDEBUG", "height");
            Resolution = $"{Width}x{Height}";
            VsyncValue = cfg.GetValue("GAMERUN", "vsync");
            Sensitivity = cfg.GetValue("GAMERUN", "mousesensitivity");
            InvMouseValue = cfg.GetValue("GAMERUN", "invmouse");
            TextureQuality = TextureNameFromDivide(cfg.GetValue("GAMERUN", "dividetexturesize"));
        }

        // Reverse of the texture-quality mapping used in Save() (name -> dividetexturesize).
        private static string TextureNameFromDivide(string? divide) => divide switch
        {
            "3" => "Low",
            "2" => "Medium",
            _ => "High"   // 0 (or anything unexpected) -> High
        };

        public void Save(string resolution, bool vsync, bool invMouse,
                         string textureQuality, int sensitivity)
        {
            var parts = resolution.Split('x');
            Width = parts[0];
            Height = parts[1];

            var cfg = new ConfigParser(AppPaths.Actual_Config_Path);

            // Texture quality
            int textureDiv = textureQuality switch
            {
                "Low" => 3,
                "Medium" => 2,
                _ => 0   // High
            };
            cfg.SetValue("GAMERUN", "dividetexturesize", textureDiv);

            cfg.SetValue("GAMERUN", "vsync", vsync ? 1 : 0);
            cfg.SetValue("GAMERUN", "invmouse", invMouse ? 1 : 0);
            cfg.SetValue("GAMEDEBUG", "width", Width);
            cfg.SetValue("GAMEDEBUG", "height", Height);
            cfg.SetValue("GAMERUN", "mousesensitivity", sensitivity.ToString());
            cfg.Save();
        }
    }
}