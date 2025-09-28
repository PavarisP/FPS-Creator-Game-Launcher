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
            Textures_Quality = new ComboBox();
            label2 = new Label();
            Resolution_Selector = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            Peekright = new ComboBox();
            label13 = new Label();
            PeekLeft = new ComboBox();
            label12 = new Label();
            Sprint = new ComboBox();
            label11 = new Label();
            Reload = new ComboBox();
            Useaction = new ComboBox();
            Crouch = new ComboBox();
            Jump = new ComboBox();
            Right_Dropdown = new ComboBox();
            Left_Dropdown = new ComboBox();
            Backward = new ComboBox();
            Forward = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            Save = new Button();
            Reset = new Button();
            Launch = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabControl1.Size = new Size(263, 511);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Textures_Quality);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Resolution_Selector);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(255, 483);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video Settings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Textures_Quality
            // 
            Textures_Quality.FormattingEnabled = true;
            Textures_Quality.Items.AddRange(new object[] { "High", "Meduim", "Low" });
            Textures_Quality.Location = new Point(128, 55);
            Textures_Quality.Name = "Textures_Quality";
            Textures_Quality.Size = new Size(121, 23);
            Textures_Quality.TabIndex = 3;
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
            // Resolution_Selector
            // 
            Resolution_Selector.FormattingEnabled = true;
            Resolution_Selector.Items.AddRange(new object[] { "1920x1080", "1080x720" });
            Resolution_Selector.Location = new Point(128, 8);
            Resolution_Selector.Name = "Resolution_Selector";
            Resolution_Selector.Size = new Size(121, 23);
            Resolution_Selector.TabIndex = 1;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(Peekright);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(PeekLeft);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(Sprint);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(Reload);
            tabPage2.Controls.Add(Useaction);
            tabPage2.Controls.Add(Crouch);
            tabPage2.Controls.Add(Jump);
            tabPage2.Controls.Add(Right_Dropdown);
            tabPage2.Controls.Add(Left_Dropdown);
            tabPage2.Controls.Add(Backward);
            tabPage2.Controls.Add(Forward);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(255, 483);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Controls";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Peekright
            // 
            Peekright.FormattingEnabled = true;
            Peekright.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Peekright.Location = new Point(105, 435);
            Peekright.Name = "Peekright";
            Peekright.Size = new Size(121, 23);
            Peekright.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 438);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 20;
            label13.Text = "Peekright";
            // 
            // PeekLeft
            // 
            PeekLeft.FormattingEnabled = true;
            PeekLeft.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            PeekLeft.Location = new Point(105, 396);
            PeekLeft.Name = "PeekLeft";
            PeekLeft.Size = new Size(121, 23);
            PeekLeft.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 399);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 18;
            label12.Text = "PeekLeft";
            // 
            // Sprint
            // 
            Sprint.FormattingEnabled = true;
            Sprint.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Sprint.Location = new Point(105, 349);
            Sprint.Name = "Sprint";
            Sprint.Size = new Size(121, 23);
            Sprint.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 352);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 16;
            label11.Text = "Sprint";
            // 
            // Reload
            // 
            Reload.FormattingEnabled = true;
            Reload.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Reload.Location = new Point(105, 307);
            Reload.Name = "Reload";
            Reload.Size = new Size(121, 23);
            Reload.TabIndex = 15;
            // 
            // Useaction
            // 
            Useaction.FormattingEnabled = true;
            Useaction.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Useaction.Location = new Point(105, 268);
            Useaction.Name = "Useaction";
            Useaction.Size = new Size(121, 23);
            Useaction.TabIndex = 14;
            // 
            // Crouch
            // 
            Crouch.FormattingEnabled = true;
            Crouch.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Crouch.Location = new Point(105, 222);
            Crouch.Name = "Crouch";
            Crouch.Size = new Size(121, 23);
            Crouch.TabIndex = 13;
            // 
            // Jump
            // 
            Jump.FormattingEnabled = true;
            Jump.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Jump.Location = new Point(105, 182);
            Jump.Name = "Jump";
            Jump.Size = new Size(121, 23);
            Jump.TabIndex = 12;
            // 
            // Right_Dropdown
            // 
            Right_Dropdown.FormattingEnabled = true;
            Right_Dropdown.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Right_Dropdown.Location = new Point(105, 136);
            Right_Dropdown.Name = "Right_Dropdown";
            Right_Dropdown.Size = new Size(121, 23);
            Right_Dropdown.TabIndex = 11;
            // 
            // Left_Dropdown
            // 
            Left_Dropdown.FormattingEnabled = true;
            Left_Dropdown.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Left_Dropdown.Location = new Point(105, 94);
            Left_Dropdown.Name = "Left_Dropdown";
            Left_Dropdown.Size = new Size(121, 23);
            Left_Dropdown.TabIndex = 10;
            // 
            // Backward
            // 
            Backward.FormattingEnabled = true;
            Backward.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Backward.Location = new Point(105, 50);
            Backward.Name = "Backward";
            Backward.Size = new Size(121, 23);
            Backward.TabIndex = 9;
            // 
            // Forward
            // 
            Forward.FormattingEnabled = true;
            Forward.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", ",", ";", ".", "[", "]", "/", "\"", "\\", "+", "~", "A", "B", "BackSpace", "C", "Capslock", "D", "Delete", "Down", "E", "End", "Enter", "Escape", "F", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "G", "H", "Home", "I", "Insert", "J", "K", "L", "LAlt", "LCtrl", "Left", "LShift", "M", "N", "Num-", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumEnter", "O", "P", "PgDown", "PgUp", "Q", "R", "RAlt", "RCtrl", "Right", "RShift", "S", "Space", "T", "Tab", "U", "Up", "V", "W", "X", "Y", "Z" });
            Forward.Location = new Point(105, 13);
            Forward.Name = "Forward";
            Forward.Size = new Size(121, 23);
            Forward.TabIndex = 8;
            Forward.SelectedValueChanged += Forward_SelectedValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 307);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 7;
            label10.Text = "Reload";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 268);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 6;
            label9.Text = "Use";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 230);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 5;
            label8.Text = "Crouch";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 185);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 4;
            label7.Text = "Jump";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 139);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 3;
            label6.Text = "Right";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 97);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 2;
            label5.Text = "Left";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 53);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 1;
            label4.Text = "Backward";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 16);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Forward";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 525);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Save
            // 
            Save.Location = new Point(12, 538);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(106, 538);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 3;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            // 
            // Launch
            // 
            Launch.Location = new Point(197, 538);
            Launch.Name = "Launch";
            Launch.Size = new Size(75, 23);
            Launch.TabIndex = 4;
            Launch.Text = "Launch";
            Launch.UseVisualStyleBackColor = true;
            Launch.Click += Launch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 568);
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
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox Textures_Quality;
        private Label label2;
        private ComboBox Resolution_Selector;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Save;
        private Button Reset;
        private Button Launch;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private ComboBox Reload;
        private ComboBox Useaction;
        private ComboBox Crouch;
        private ComboBox Jump;
        private ComboBox Right_Dropdown;
        private ComboBox Left_Dropdown;
        private ComboBox Backward;
        private ComboBox Forward;
        private ComboBox Sprint;
        private Label label11;
        private ComboBox PeekLeft;
        private Label label12;
        private ComboBox Peekright;
        private Label label13;
    }
}