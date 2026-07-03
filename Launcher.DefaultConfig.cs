using Salaros.Configuration;
using System.IO;

namespace FPS_Creator_Game_Launcher
{
    // Creation of a brand-new setup.ini populated with the game's default values.
    public partial class Launcher
    {
        // Game config
        private const string Language = "english";
        private const string UniqueGameCode = ""; // Custom unique game code for multiplayer games, if applicable.
        private const int LevelMax = 1; // Set the maximum number of levels in your game.

        private void CreateNewIni(string filename)
        {
            // Ensure the target directory exists before writing the file.
            string? directory = Path.GetDirectoryName(filename);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

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
            cfg.SetValue("GAMEPROFILE", "key2", 31);
            cfg.SetValue("GAMEPROFILE", "key3", 30);
            cfg.SetValue("GAMEPROFILE", "key4", 32);
            cfg.SetValue("GAMEPROFILE", "key5", 57);
            cfg.SetValue("GAMEPROFILE", "key6", 46);
            cfg.SetValue("GAMEPROFILE", "key7", 28);
            cfg.SetValue("GAMEPROFILE", "key8", 19);
            cfg.SetValue("GAMEPROFILE", "key9", 16);
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
    }
}
