using Salaros.Configuration;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FPS_Creator_Game_Launcher
{
    public partial class Form1 : Form
    {
        // Game config
        private static readonly string Language = "english";
        private static readonly string UniqueGameCode = "";
        private static readonly int LevelMax = 1;

        private readonly KeyConfig _keyConfig = new();
        private readonly VideoSettings _videoSettings = new();

        private bool _saveSuccess = false;

        public Form1()
        {
            InitializeComponent();
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

        // ── Apply loaded values to UI ─────────────────────────────────────────

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
            }
            catch
            {
                SetDefault();
            }
        }

        // ── Load from ini ──────────────────────────────────────────────────────

        private void LoadAll()
        {
            _keyConfig.Load();
            _videoSettings.Load();
            ApplyLoadedValues();
        }

        // ── Save to ini ───────────────────────────────────────────────────────

        private bool SaveAll()
        {
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

        // ── Create new ini with defaults ──────────────────────────────────────

        private void CreateNewIni(string filename)
        {
            // Extract directory path and ensure it exists before file creation
            string directory = Path.GetDirectoryName(filename);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Pass the specific filename to ensure writing to the correct path
            WriteDefaultIni(filename);
        }

        private void WriteDefaultIni(string filename)
        {
            int nooftaunts = 1;
            var cfg = new ConfigParser(filename);

            cfg.SetValue("GENRE", "gametype", 0);
            cfg.SetValue("GENRE", " serverhostname", "FPSC Arena");
            while (nooftaunts <= 30) { cfg.SetValue("GENRE", $"taunt{nooftaunts}", ""); nooftaunts++; }
            nooftaunts = 1;

            cfg.SetValue("GAMERUN", "realgameview", 1);
            cfg.SetValue("GAMERUN", "dynamiclighting", 1);
            cfg.SetValue("GAMERUN", "useeffects", 1);
            cfg.SetValue("GAMERUN", "useeffectsonguns", 1);
            cfg.SetValue("GAMERUN", "useeffectsonscene", 1);
            cfg.SetValue("GAMERUN", "lightmapperbypass", 1);
            cfg.SetValue("GAMERUN", "low_spec_mode", 0);
            cfg.SetValue("GAMERUN", "skyboxfog", 0);
            cfg.SetValue("GAMERUN", "shaderweapons", 0);
            cfg.SetValue("GAMERUN", "useeffectsonentities", 1);
            cfg.SetValue("GAMERUN", "dividetexturesize", 2);
            cfg.SetValue("GAMERUN", "xbox", 0);
            cfg.SetValue("GAMERUN", "xboxmag", 25);
            cfg.SetValue("GAMERUN", "controllerhint", 0);
            cfg.SetValue("GAMERUN", "vrmode", 0);
            cfg.SetValue("GAMERUN", "vrmodemag", 100);
            cfg.SetValue("GAMERUN", "mousesensitivity", 100);
            cfg.SetValue("GAMERUN", "producelogfiles", 0);
            cfg.SetValue("GAMERUN", "hsrmode", 2);
            cfg.SetValue("GAMERUN", "aspectratio", 1);
            cfg.SetValue("GAMERUN", "newblossershaders", 1);
            cfg.SetValue("GAMERUN", "postprocessing", 1);
            cfg.SetValue("GAMERUN", "invmouse", 0);
            cfg.SetValue("GAMERUN", "atten", 500);
            cfg.SetValue("GAMERUN", "darkaion", 1);
            cfg.SetValue("GAMERUN", "marblefloor", 0);
            cfg.SetValue("GAMERUN", "newlight", 1);
            cfg.SetValue("GAMERUN", "physx", 1);
            cfg.SetValue("GAMERUN", "gluedgun", 0);
            cfg.SetValue("GAMERUN", "flashon", 2);
            cfg.SetValue("GAMERUN", "blob_shadow", 2);
            cfg.SetValue("GAMERUN", "vsync", 1);
            cfg.SetValue("GAMERUN", "showaioutlines", 0);
            cfg.SetValue("GAMERUN", "airadius", 20);
            cfg.SetValue("GAMERUN", "disablepeeking", 0);
            cfg.SetValue("GAMERUN", "disableparticles", 0);

            cfg.SetValue("GAMEMULTIPLAYER", "multiplayergame", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "gameobjectivetype", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "gameobjectivevalue", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "oneshotkills", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "maxplayers", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "spawnrandom", 1);
            cfg.SetValue("GAMEMULTIPLAYER", "uniquegamecode", UniqueGameCode);

            cfg.SetValue("GAMEDEBUG", "height", 1020);
            cfg.SetValue("GAMEDEBUG", "width", 1980);
            cfg.SetValue("GAMEDEBUG", "depth", 32);
            cfg.SetValue("GAMEDEBUG", "usesky", 1);
            cfg.SetValue("GAMEDEBUG", "usefloor", 0);
            cfg.SetValue("GAMEDEBUG", "useenvsounds", 1);
            cfg.SetValue("GAMEDEBUG", "useweapons", 1);

            cfg.SetValue("GAMEPROFILE", "title", $"languagebank\\{Language}\\gamebank\\mygame\\titlepage.fpi");
            cfg.SetValue("GAMEPROFILE", "global", $"languagebank\\{Language}\\gamebank\\mygame\\setuplevel.fpi");
            cfg.SetValue("GAMEPROFILE", "gamewon", $"languagebank\\{Language}\\gamebank\\mygame\\gamewon.fpi");
            cfg.SetValue("GAMEPROFILE", "gameover", $"languagebank\\{Language}\\gamebank\\mygame\\gameover.fpi");
            cfg.SetValue("GAMEPROFILE", "key1", 17);
            cfg.SetValue("GAMEPROFILE", "key2 ", 31);
            cfg.SetValue("GAMEPROFILE", "key3", 30);
            cfg.SetValue("GAMEPROFILE", "key4", 32);
            cfg.SetValue("GAMEPROFILE", "key5", 57);
            cfg.SetValue("GAMEPROFILE", "key6", 46);
            cfg.SetValue("GAMEPROFILE", "key7 ", 72);
            cfg.SetValue("GAMEPROFILE", "key8", 19);
            cfg.SetValue("GAMEPROFILE", "key9 ", 16);
            cfg.SetValue("GAMEPROFILE", "key10", 18);
            cfg.SetValue("GAMEPROFILE", "key11", 42);

            while (nooftaunts <= 30) { cfg.SetValue("GAMEPROFILE", $"taunt{nooftaunts}", ""); nooftaunts++; }

            for (int slot = 1; slot <= 9; slot++)
                cfg.SetValue("GAMEPROFILE", $"slot{slot}", "");

            cfg.SetValue("GAMEPROFILE", "levelmax", LevelMax);
            for (int level = 1; level <= LevelMax; level++)
            {
                cfg.SetValue("GAMEPROFILE", $"levelfpm{level}", $"mapbank\\horrorgame\\{level}.fpm");
                string loadingFpi = level == 1
                    ? $"languagebank\\{Language}\\gamebank\\mygame\\loadingpage.fpi"
                    : $"languagebank\\{Language}\\gamebank\\mygame\\loadingpage{level}.fpi";
                cfg.SetValue("GAMEPROFILE", $"levelfpi{level}", loadingFpi);
            }
            cfg.Save();

            SetDefault();
        }

        // ── Form events ───────────────────────────────────────────────────────

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppPaths.Actual_Config_Path))
                CreateNewIni(AppPaths.Actual_Config_Path);
            else
                LoadAll();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveAll())
                MessageBox.Show("Setting saved.");
        }

        private void Launch_Click(object sender, EventArgs e)
        {
            _saveSuccess = SaveAll();
            if (!_saveSuccess)
            {
                MessageBox.Show("Please save the settings before launching the game.");
                return;
            }

            try
            {
                var process = new Process();
                process.StartInfo.WorkingDirectory = AppPaths.FullPath;
                process.StartInfo.FileName = Path.Combine(AppPaths.FullPath, AppPaths.GameExeName);
                process.StartInfo.UseShellExecute = true;

                process.Start();
                Hide();
                process.WaitForExit();
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("There is an error, please try again.", "Error!");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void button1_Click(object sender, EventArgs e) { }
    }
}