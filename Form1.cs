using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FPS_Creator_Game_Launcher
{
    public partial class Form1 : Form

    {
        public static string rel_path = Directory.GetCurrentDirectory();

        public string full_path = rel_path + @"\Horror\"; //Make sure to have the slash at the end and change "Horror" to the game folder name

        //Save keys

        public string ForwardKey, BackwardKey, LeftKey, RightKey, JumpKey, CrouchKey, SprintKey, UseKey, ReloadKey, MeleeKey, ProneKey, PeekLeftKey, PeekRightKey;

        //loaded keys

        public string LoadedForwardKey, LoadedBackwardKey, LoadedLeftKey, LoadedRightKey, LoadedJumpKey, LoadedCrouchKey, LoadedSprintKey, LoadedUseKey, LoadedReloadKey, LoadedMeleeKey, LoadedProneKey, LoadedPeekLeftKey, LoadedPeekRightKey;

        //Setkey

        //loaded Resolution

        public string LoadedResolution, Loadedheight, Loadedwidth;

        //Save Resolution

        public string Resolution, Height, Width, delimiter = "x";

        // Config path

        public string configpath = rel_path + @"\Horror\Setup.ini";//Make sure to change "Horror" to the game folder name and have the slash at the end


        public Form1()
        {
            InitializeComponent();

        }
        //Dictionary for keyboard layout (Save)
        Dictionary<string, int> keyboardLayout = new Dictionary<string, int>

        {

                {"Escape",1},

                {"1",2},

                {"2",3},

                {"3",4},

                {"4",5},

                {"5",6},

                {"6",7},

                {"7",8},

                {"8",9},

                {"9",10},

                {"0",11},

                {"-",12},

                {"+",13},

                {"BackSpace",14},

                {"Tab",15},

                {"Q",16},

                {"W",17},

                {"E",18},

                {"R",19},

                {"T",20},

                {"Y",21},

                {"U",22},

                {"I",23},

                {"O",24},

                {"P",25},

                {"[",26},

                {"]",27},

                {"Enter",28},

                {"LCtrl",29},

                {"A",30},

                {"S",31},

                {"D",32},

                {"F",33},

                {"G",34},

                {"H",35},

                {"J",36},

                {"K",37},

                {"L",38},

                {";",39},

                {"\"",40},

                {"~",41},

                {"LShift",42},

                {"\\",43},

                {"Z",44},

                {"X",45},

                {"C",46},

                {"V",47},

                {"B",48},

                {"N",49},

                {"M",50},

                {",",51},

                {".",52},

                {"/",53},

                {"RShift",54},

                {"LAlt",56},

                {"Space",57},

                {"Capslock",58},

                {"F1",59},

                {"F2",60},

                {"F3",61},

                {"F4",62},

                {"F5",63},

                {"F6",64},

                {"F7",65},

                {"F8",66},

                {"F9",67},

                {"F10",68},

                {"F11",69},

                {"F12",70},

                {"Num7",71},

                {"Num8",72},

                {"Num9",73},

                {"Num4",75},

                {"Num5",76},

                {"Num6",77},

                {"Num1",79},

                {"Num2",80},

                {"Num3",81},

                {"Num0",82},

                {"Num-",83},

                {"NumEnter",156},

                {"RCtrl",157},

                {"RAlt",184},

                {"Home",199},

                {"Up",200},

                {"PgUp",201},

                {"Left",203},

                {"Right",205},

                {"End",207},

                {"Down",208},

                {"PgDown",209},

                {"Insert",210},

                {"Delete",211},

        };

        void setkeys()

        {

            //FindKey in dictionary

            //LinQ Reversedictionary to get key from value
            /*

            var reversedkeyboardLayout = keyboardLayout.ToDictionary(x => x.Value, x => x.Key);

            ForwardKey = reversedkeyboardLayout.FirstOrDefault(kvp => kvp.Value == LoadedForwardKey).Value;

            BackwardKey = reversedkeyboardLayout.FirstOrDefault(kvp => kvp.Value == LoadedBackwardKey).Value;

            LeftKey = reversedkeyboardLayout.FirstOrDefault(kvp => kvp.Value == LoadedLeftKey).Value;

            RightKey = reversedkeyboardLayout.FirstOrDefault(kvp => kvp.Value == LoadedRightKey).Value;

            JumpKey = reversedkeyboardLayout.FirstOrDefault(kvp => kvp.Value == LoadedJumpKey).Value;

            CrouchKey = reversedkeyboardLayout.FirstOrDefault(kvp => kvp.Value == LoadedCrouchKey).Value;

            UseKey = reversedkeyboardLayout.FirstOrDefault(kvp => kvp.Value == LoadedUseKey).Value;

            ReloadKey = reversedkeyboardLayout.FirstOrDefault(kvp => kvp.Value == LoadedReloadKey).Value;
            */


            //Set Dropdown text

            Forward.Text = ForwardKey;

            Backward.Text = BackwardKey;

            Left.Text = LeftKey;

            Right.Text = RightKey;

            Jump.Text = JumpKey;

            Crouch.Text = CrouchKey;

            Useaction.Text = UseKey;

            Reload.Text = ReloadKey;



        }

        void loadvalue()

        {

            var cfg = new ConfigParser(configpath);

            //Keys

            LoadedForwardKey = cfg.GetValue("GAMEPROFILE", "key1");

            LoadedBackwardKey = cfg.GetValue("GAMEPROFILE", "key2");

            LoadedLeftKey = cfg.GetValue("GAMEPROFILE", "key3");

            LoadedRightKey = cfg.GetValue("GAMEPROFILE", "key4");

            LoadedJumpKey = cfg.GetValue("GAMEPROFILE", "key5");

            LoadedCrouchKey = cfg.GetValue("GAMEPROFILE", "key6");

            LoadedUseKey = cfg.GetValue("GAMEPROFILE", "key7");

            LoadedReloadKey = cfg.GetValue("GAMEPROFILE", "key8");

            //setting keys

            setkeys();

            //Resolution

            LoadedResolution = cfg.GetValue("GAMEDEBUG", "width") + "x" + cfg.GetValue("GAMEDEBUG", "height");

        }


        private void Form1_Load(object sender, EventArgs e)

        {

            loadvalue();

            tabControl1.Enabled = true;

            Resolution_Selector.Text = LoadedResolution;





        }


        private void button1_Click(object sender, EventArgs e)

        { }





        //Forward Ket dropdown

        private void Forward_SelectedValueChanged(object sender, EventArgs e)

        {

            ForwardKey = keyboardLayout[Forward.Text].ToString();



        }


        //Backward Key dropdown

        private void Backward_SelectedValueChanged(object sender, EventArgs e)

        {

            BackwardKey = keyboardLayout[Backward.Text].ToString();

        }


        private void Left_SelectedValueChanged(object sender, EventArgs e)

        {

            LeftKey = keyboardLayout[Left.Text].ToString();

        }


        private void Right_SelectedValueChanged(object sender, EventArgs e)

        {

            RightKey = keyboardLayout[Right.Text].ToString();

        }


        private void Jump_SelectedValueChanged(object sender, EventArgs e)

        {

            JumpKey = keyboardLayout[Jump.Text].ToString();

        }


        private void Crouch_SelectedValueChanged(object sender, EventArgs e)

        {

            CrouchKey = keyboardLayout[Crouch.Text].ToString();
        }
        private void Sprint_SelectedValueChanged(object sender, EventArgs e)

        {

            SprintKey = keyboardLayout[Sprint.Text].ToString();

        }


        private void Useaction_SelectedValueChanged(object sender, EventArgs e)

        {

            UseKey = keyboardLayout[Useaction.Text].ToString();

        }


        private void Reload_SelectedIndexChanged(object sender, EventArgs e)

        {

            ReloadKey = keyboardLayout[Reload.Text].ToString();

        }


        private void Peekleft_SelectedValueChanged(object sender, EventArgs e)

        {

            PeekLeftKey = keyboardLayout[PeekLeft.Text].ToString();

        }


        private void PeekRight_SelectedValueChanged(object sender, EventArgs e)

        {

            PeekRightKey = keyboardLayout[Peekright.Text].ToString();

        }


        private void Resolution_Selector_SelectedValueChanged(object sender, EventArgs e)

        {

            //Video Resolution dropdown

            Resolution = Resolution_Selector.Text;

            Height = Resolution.Split(delimiter)[0];

            Width = Resolution.Split(delimiter)[1];

        }

        private void Save_Click(object sender, EventArgs e)
        {
            //Save button
            try
            {
                var cfg = new ConfigParser(configpath);

                cfg.SetValue("GAMEPROFILE", "key1", ForwardKey);
                cfg.SetValue("GAMEPROFILE", "key2", BackwardKey);
                cfg.SetValue("GAMEPROFILE", "key3", LeftKey);
                cfg.SetValue("GAMEPROFILE", "key4", RightKey);
                cfg.SetValue("GAMEPROFILE", "key5", JumpKey);
                cfg.SetValue("GAMEPROFILE", "key6", CrouchKey);
                cfg.SetValue("GAMEPROFILE", "key7", UseKey);
                cfg.SetValue("GAMEPROFILE", "key8", ReloadKey);
                cfg.SetValue("GAMEPROFILE", "key9", PeekLeftKey);
                cfg.SetValue("GAMEPROFILE", "key10", PeekRightKey);

                cfg.SetValue("GAMEDEBUG", "height", Height);
                cfg.SetValue("GAMEDEBUG", "width", Width);
                cfg.Save();

                MessageBox.Show("Settings saved to: " + configpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message);
            }
        }

        private void Launch_Click(object sender, EventArgs e)
        {
            Process P = new Process();

            string gameexe = P.StartInfo.WorkingDirectory = full_path;

            P.StartInfo.FileName = gameexe + @"Horror.exe";

            P.Start();

            Application.Exit();
        }
    }
}

