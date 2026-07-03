using System;
using System.Windows.Forms;

namespace FPS_Creator_Game_Launcher
{
    // Thin form shell: holds the config models and wires UI events to the
    // logic that lives in the Launcher.*.cs partial files.
    public partial class Launcher : Form
    {
        private readonly KeyConfig _keyConfig = new();
        private readonly VideoSettings _videoSettings = new();

        public Launcher()
        {
            InitializeComponent();
        }

        // ── Form events ───────────────────────────────────────────────────────

        private void Launcher_Load(object sender, EventArgs e) => LoadOrCreateConfig();

        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveAndDeploy())
                MessageBox.Show("Setting saved.");
        }

        private void Launch_Click(object sender, EventArgs e) => LaunchGame();

        private void Reset_Click(object sender, EventArgs e) => SetDefault();
    }
}
