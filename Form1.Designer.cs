namespace FPS_Creator_Game_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Resolution = new ComboBox();
            label2 = new Label();
            Textures_Quality = new ComboBox();
            Save = new Button();
            Reset = new Button();
            Launch = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(263, 349);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Textures_Quality);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Resolution);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(255, 321);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video Settings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(255, 321);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Controls";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lightmapoff;
            pictureBox1.Location = new Point(305, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(489, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Resolution";
            // 
            // Resolution
            // 
            Resolution.FormattingEnabled = true;
            Resolution.Items.AddRange(new object[] { "1920x1080", "1080x720" });
            Resolution.Location = new Point(128, 8);
            Resolution.Name = "Resolution";
            Resolution.Size = new Size(121, 23);
            Resolution.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 58);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Textures Quality";
            // 
            // Textures_Quality
            // 
            Textures_Quality.FormattingEnabled = true;
            Textures_Quality.Items.AddRange(new object[] { "1920x1080", "1080x720" });
            Textures_Quality.Location = new Point(128, 55);
            Textures_Quality.Name = "Textures_Quality";
            Textures_Quality.Size = new Size(121, 23);
            Textures_Quality.TabIndex = 3;
            // 
            // Save
            // 
            Save.Location = new Point(11, 386);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            Reset.Location = new Point(105, 386);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 3;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            // 
            // Launch
            // 
            Launch.Location = new Point(196, 386);
            Launch.Name = "Launch";
            Launch.Size = new Size(75, 23);
            Launch.TabIndex = 4;
            Launch.Text = "Launch";
            Launch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(Launch);
            Controls.Add(Reset);
            Controls.Add(Save);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Launcher";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox Textures_Quality;
        private Label label2;
        private ComboBox Resolution;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Save;
        private Button Reset;
        private Button Launch;
    }
}