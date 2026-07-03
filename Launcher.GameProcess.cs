using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FPS_Creator_Game_Launcher
{
    // Saving the current settings and starting the game executable.
    public partial class Launcher
    {
        private void LaunchGame()
        {
            if (!SaveAndDeploy())
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
    }
}
