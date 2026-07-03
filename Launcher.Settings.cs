using System.IO;
using System.Windows.Forms;

namespace FPS_Creator_Game_Launcher
{
    // Settings <-> UI: loading, applying, defaulting and saving the launcher controls.
    public partial class Launcher
    {
        // ── Entry point called on form load ───────────────────────────────────

        // The Documents ini (Actual_Config_Path) is the persistent master: it holds
        // the settings the player last saved and survives between sessions. The game
        // folder ini (ConfigPath) is extracted and deleted every run by the Vishnu
        // launcher, so we always rebuild it from the master.
        private void LoadOrCreateConfig()
        {
            string master = AppPaths.Actual_Config_Path;

            if (!File.Exists(master) || new FileInfo(master).Length == 0)
                CreateNewIni(master);   // first run / empty file -> write defaults + default UI
            else
                LoadAll();              // saved settings exist -> load them into the UI

            DeployToGameFolder();       // mirror the master into the game folder
        }

        // ── Persist + deploy ──────────────────────────────────────────────────

        // Saves the current UI to the Documents master, then copies it into the
        // game folder. Used by both the Save button and Launch.
        private bool SaveAndDeploy() => SaveAll() && DeployToGameFolder();

        // Copies the persistent Documents ini into the (ephemeral) game folder so
        // the game engine reads the player's saved settings, replacing whatever the
        // Vishnu launcher extracted.
        private bool DeployToGameFolder()
        {
            try
            {
                string? gameDir = Path.GetDirectoryName(AppPaths.ConfigPath);
                if (!string.IsNullOrEmpty(gameDir) && !Directory.Exists(gameDir))
                    Directory.CreateDirectory(gameDir);

                File.Copy(AppPaths.Actual_Config_Path, AppPaths.ConfigPath, overwrite: true);
                return true;
            }
            catch
            {
                MessageBox.Show("Could not copy the settings into the game folder. Please try again.");
                return false;
            }
        }

        // ── Default UI values ─────────────────────────────────────────────────

        private void SetDefault()
        {
            Forward.Text = "W";
            Backward.Text = "S";
            Left_Dropdown.Text = "A";
            Right_Dropdown.Text = "D";
            Jump.Text = "Space";
            Useaction.Text = "Enter";
            Crouch.Text = "C";
            Reload.Text = "R";
            Sprint.Text = "LShift";
            PeekLeft.Text = "Q";
            Peekright.Text = "E";
            Resolution_Selector.Text = "1920x1080";
            Textures_Quality.Text = "High";
            Vsync.Checked = true;
            Mouse_Sensitivity.Value = 100;
        }

        // ── Load from ini and apply to UI ─────────────────────────────────────

        private void LoadAll()
        {
            _keyConfig.Load();
            _videoSettings.Load();
            ApplyLoadedValues();
        }

        private void ApplyLoadedValues()
        {
            try
            {
                Forward.Text = _keyConfig.Resolve(_keyConfig.Forward);
                Backward.Text = _keyConfig.Resolve(_keyConfig.Backward);
                Left_Dropdown.Text = _keyConfig.Resolve(_keyConfig.Left);
                Right_Dropdown.Text = _keyConfig.Resolve(_keyConfig.Right);
                Jump.Text = _keyConfig.Resolve(_keyConfig.Jump);
                Crouch.Text = _keyConfig.Resolve(_keyConfig.Crouch);
                Useaction.Text = _keyConfig.Resolve(_keyConfig.Use);
                Reload.Text = _keyConfig.Resolve(_keyConfig.Reload);
                Sprint.Text = _keyConfig.Resolve(_keyConfig.Sprint);
                PeekLeft.Text = _keyConfig.Resolve(_keyConfig.PeekLeft);
                Peekright.Text = _keyConfig.Resolve(_keyConfig.PeekRight);

                Resolution_Selector.Text = _videoSettings.Resolution;
                Mouse_Sensitivity.Value = int.Parse(_videoSettings.Sensitivity ?? "100");
                Vsync.Checked = _videoSettings.VsyncValue == "1";
                Textures_Quality.Text = _videoSettings.TextureQuality;
                Invmouse.Checked = _videoSettings.InvMouseValue == "1";
            }
            catch
            {
                SetDefault();
            }
        }

        // ── Keybind validation ────────────────────────────────────────────────

        // Rejects the save if two controls are bound to the same key (e.g. Forward
        // and Backward both set to "W"). Reports the first clash it finds.
        private bool ValidateKeybinds()
        {
            var binds = new (string Label, string Key)[]
            {
                ("Forward", Forward.Text),
                ("Backward", Backward.Text),
                ("Left", Left_Dropdown.Text),
                ("Right", Right_Dropdown.Text),
                ("Jump", Jump.Text),
                ("Crouch", Crouch.Text),
                ("Use", Useaction.Text),
                ("Reload", Reload.Text),
                ("Sprint", Sprint.Text),
                ("PeekLeft", PeekLeft.Text),
                ("PeekRight", Peekright.Text),
            };

            var seen = new Dictionary<string, string>();
            foreach (var (label, key) in binds)
            {
                if (string.IsNullOrEmpty(key))
                    continue;

                if (seen.TryGetValue(key, out string? other))
                {
                    MessageBox.Show(
                        $"'{key}' is assigned to both {other} and {label}.\n" +
                        "Each control must use a different key.",
                        "Duplicate key binding");
                    return false;
                }

                seen[key] = label;
            }

            return true;
        }

        // ── Save UI back to ini ───────────────────────────────────────────────

        private bool SaveAll()
        {
            if (!ValidateKeybinds())
                return false;

            try
            {
                string forwardCode = KeyboardMaps.KeyToCode[Forward.Text].ToString();
                string backwardCode = KeyboardMaps.KeyToCode[Backward.Text].ToString();
                string leftCode = KeyboardMaps.KeyToCode[Left_Dropdown.Text].ToString();
                string rightCode = KeyboardMaps.KeyToCode[Right_Dropdown.Text].ToString();
                string jumpCode = KeyboardMaps.KeyToCode[Jump.Text].ToString();
                string crouchCode = KeyboardMaps.KeyToCode[Crouch.Text].ToString();
                string sprintCode = KeyboardMaps.KeyToCode[Sprint.Text].ToString();
                string useCode = KeyboardMaps.KeyToCode[Useaction.Text].ToString();
                string reloadCode = KeyboardMaps.KeyToCode[Reload.Text].ToString();
                string peekLeftCode = KeyboardMaps.KeyToCode[PeekLeft.Text].ToString();
                string peekRightCode = KeyboardMaps.KeyToCode[Peekright.Text].ToString();

                _keyConfig.Save(forwardCode, backwardCode, leftCode, rightCode,
                                jumpCode, crouchCode, sprintCode, useCode,
                                reloadCode, peekLeftCode, peekRightCode);

                _videoSettings.Save(
                    Resolution_Selector.Text,
                    Vsync.Checked,
                    Invmouse.Checked,
                    Textures_Quality.Text,
                    (int)Mouse_Sensitivity.Value);

                return true;
            }
            catch
            {
                MessageBox.Show("There is an error, please try again. If the problem still persists, use the default settings.");
                return false;
            }
        }
    }
}
