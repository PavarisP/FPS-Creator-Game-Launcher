using System;
using System.IO;

namespace FPS_Creator_Game_Launcher
{
    public static class AppPaths
    {
        public static readonly string RelPath = AppDomain.CurrentDomain.BaseDirectory;

        public static readonly string GameFolderName = "Horror"; // Change this to your game folder name

        public static readonly string FullPath = Path.Combine(RelPath, GameFolderName);

        public static readonly string ConfigPath = Path.Combine(RelPath, GameFolderName, "setup.ini");

        public static readonly string GameExeName = "Horror.exe"; // Change this to your game exe name

        public static readonly string SaveConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static readonly string Actual_Config_Path = Path.Combine(SaveConfigPath, GameFolderName, "setup.ini");
    }
}

