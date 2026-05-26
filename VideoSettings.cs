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

        public void Load()
        {
            var cfg = new ConfigParser(AppPaths.ConfigPath);
            Width = cfg.GetValue("GAMEDEBUG", "width");
            Height = cfg.GetValue("GAMEDEBUG", "height");
            Resolution = $"{Width}x{Height}";
            VsyncValue = cfg.GetValue("GAMERUN", "vsync");
            Sensitivity = cfg.GetValue("GAMERUN", "mousesensitivity");
        }

        public void Save(string resolution, bool vsync, bool invMouse,
                         string textureQuality, int sensitivity)
        {
            var parts = resolution.Split('x');
            Width = parts[0];
            Height = parts[1];

            var cfg = new ConfigParser(AppPaths.ConfigPath);

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