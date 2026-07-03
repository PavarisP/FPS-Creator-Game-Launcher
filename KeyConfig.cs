using Salaros.Configuration;

namespace FPS_Creator_Game_Launcher
{
    public class KeyConfig
    {
        // Loaded raw scan codes from ini
        public string? Forward, Backward, Left, Right, Jump, Crouch,
                        Sprint, Use, Reload, PeekLeft, PeekRight;

        public void Load()
        {
            var cfg = new ConfigParser(AppPaths.Actual_Config_Path);
            Forward = cfg.GetValue("GAMEPROFILE", "key1");
            Backward = cfg.GetValue("GAMEPROFILE", "key2");
            Left = cfg.GetValue("GAMEPROFILE", "key3");
            Right = cfg.GetValue("GAMEPROFILE", "key4");
            Jump = cfg.GetValue("GAMEPROFILE", "key5");
            Crouch = cfg.GetValue("GAMEPROFILE", "key6");
            Use = cfg.GetValue("GAMEPROFILE", "key7");
            Reload = cfg.GetValue("GAMEPROFILE", "key8");
            PeekLeft = cfg.GetValue("GAMEPROFILE", "key9");
            PeekRight = cfg.GetValue("GAMEPROFILE", "key10");
            Sprint = cfg.GetValue("GAMEPROFILE", "key11");
        }

        public void Save(string forwardCode, string backwardCode, string leftCode,
                         string rightCode, string jumpCode, string crouchCode,
                         string sprintCode, string useCode, string reloadCode,
                         string peekLeftCode, string peekRightCode)
        {
            var cfg = new ConfigParser(AppPaths.Actual_Config_Path);
            cfg.SetValue("GAMEPROFILE", "key1", forwardCode);
            cfg.SetValue("GAMEPROFILE", "key2", backwardCode);
            cfg.SetValue("GAMEPROFILE", "key3", leftCode);
            cfg.SetValue("GAMEPROFILE", "key4", rightCode);
            cfg.SetValue("GAMEPROFILE", "key5", jumpCode);
            cfg.SetValue("GAMEPROFILE", "key6", crouchCode);
            cfg.SetValue("GAMEPROFILE", "key7", useCode);
            cfg.SetValue("GAMEPROFILE", "key8", reloadCode);
            cfg.SetValue("GAMEPROFILE", "key9", peekLeftCode);
            cfg.SetValue("GAMEPROFILE", "key10", peekRightCode);
            cfg.SetValue("GAMEPROFILE", "key11", sprintCode);
            cfg.Save();
        }

        // Resolve loaded scan code to key name for display
        public string Resolve(string? scanCode)
        {
            if (scanCode == null) return "";
            return KeyboardMaps.CodeToKey.TryGetValue(scanCode, out var name) ? name : "";
        }
    }
}