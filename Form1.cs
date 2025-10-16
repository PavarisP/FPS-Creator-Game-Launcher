using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Media;
using System.Web;

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

        public int nroflevels = 1; //set this to the number of levels in your game

        public int nroflevels = 1; //set this to the number of levels in your game

        //language
        public string? language="english"; //Set this as the language of your game

        //unique game code
        public string? uniquegamecode= "01o84r/:r22o40r/:.25e41x01e84H/:";//set you unique game code here, this is important for multiplayer games

        //loaded Resolution

        public string LoadedResolution, Loadedheight, Loadedwidth;

        //Save Resolution

        public string Resolution, Height, Width, delimiter = "x";

        // Config path

        public string configpath = rel_path + @"\Horror\setup.ini";//Make sure to change "Horror" to the game folder name and have the slash at the end
       // public string Mousehoversound= Properties.Resources.MySound;

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

        //Dictionary for keyboard layout (Load)
        Dictionary<string, string> reversedkeyboardLayout = new Dictionary<string, string>() {
        {"11","0"},
        {"2","1"},
        {"3","2"},
        {"4","3"},
        {"5","4"},
        {"6","5"},
        {"7","6"},
        {"8","7"},
        {"9","8"},
        {"10","9"},
        {"12","-"},
        {"51",","},
        {"39",";"},
        {"52","."},
        {"26","["},
        {"27","]"},
        {"53","/"},
        {"40","\""},
        {"43","\\"},
        {"13","+"},
        {"41","~"},
        {"30","A"},
        {"48","B"},
        {"14","BackSpace"},
        {"46","C"},
        {"58","Capslock"},
        {"32","D"},
        {"211","Delete"},
        {"208","Down"},
        {"18","E"},
        {"207","End"},
        {"28","Enter"},
        {"1","Escape"},
        {"33","F"},
        {"59","F1"},
        {"68","F10"},
        {"69","F11"},
        {"70","F12"},
        {"60","F2"},
        {"61","F3"},
        {"62","F4"},
        {"63","F5"},
        {"64","F6"},
        {"65","F7"},
        {"66","F8"},
        {"67","F9"},
        {"34","G"},
        {"35","H"},
        {"199","Home"},
        {"23","I"},
        {"210","Insert"},
        {"36","J"},
        {"37","K"},
        {"38","L"},
        {"56","LAlt"},
        {"29","LCtrl"},
        {"203","Left"},
        {"42","LShift"},
        {"50","M"},
        {"49","N"},
        {"83","Num-"},
        {"82","Num0"},
        {"79","Num1"},
        {"80","Num2"},
        {"81","Num3"},
        {"75","Num4"},
        {"76","Num5"},
        {"77","Num6"},
        {"71","Num7"},
        {"72","Num8"},
        {"73","Num9"},
        {"156","NumEnter"},
        {"24","O"},
        {"25","P"},
        {"209","PgDown"},
        {"201","PgUp"},
        {"16","Q"},
        {"19","R"},
        {"184","RAlt"},
        {"157","RCtrl"},
        {"205","Right"},
        {"54","RShift"},
        {"31","S"},
        {"57","Space"},
        {"20","T"},
        {"15","Tab"},
        {"22","U"},
        {"200","Up"},
        {"47","V"},
        {"17","W"},
        {"45","X"},
        {"21","Y"},
        {"44","Z"},
        };

        void setdefault()
        {
            //Setting Detault settings
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
        }


        void setkeys()

        {
            try
            {
                ForwardKey = reversedkeyboardLayout[LoadedForwardKey].ToString();
                Forward.Text = ForwardKey;
                BackwardKey = reversedkeyboardLayout[LoadedBackwardKey].ToString();
                Backward.Text = BackwardKey;
                LeftKey = reversedkeyboardLayout[LoadedLeftKey].ToString();
                Left_Dropdown.Text = LeftKey;
                RightKey = reversedkeyboardLayout[LoadedRightKey].ToString();
                Right_Dropdown.Text = RightKey;
                JumpKey = reversedkeyboardLayout[LoadedJumpKey].ToString();
                Jump.Text = JumpKey;
                CrouchKey = reversedkeyboardLayout[LoadedCrouchKey].ToString();
                Crouch.Text = CrouchKey;
                UseKey = reversedkeyboardLayout[LoadedUseKey].ToString();
                Useaction.Text = UseKey;
                ReloadKey = reversedkeyboardLayout[LoadedReloadKey].ToString();
                Reload.Text = ReloadKey;
                SprintKey = reversedkeyboardLayout[LoadedSprintKey].ToString();
                Sprint.Text = SprintKey;
                PeekLeftKey = reversedkeyboardLayout[LoadedPeekLeftKey].ToString();
                PeekLeft.Text = PeekLeftKey;
                PeekRightKey = reversedkeyboardLayout[LoadedPeekRightKey].ToString();
                Peekright.Text = PeekRightKey;
                Resolution = LoadedResolution;
                Resolution_Selector.Text = Resolution;




            }
            catch (Exception)
            {
                setdefault();
            }
        }

        void createnewini(string filename)
        {
            using (FileStream fs = File.Create(filename));
            loadnewdefault();
        }

        void loadnewdefault()
        {
            //You can change any default in setting here, it will be the default settings when the setup.ini file does not exist.
            //GENRE section
            int nooftaunts = 1;
            var cfg = new ConfigParser(configpath);
            cfg.SetValue("GENRE", "gametype", 0);//Set this to 0 for single player games and 1 for multiplayer games
            cfg.SetValue("GENRE", " serverhostname","FPSC Arena");
            while (nooftaunts <= 30)
            {
                cfg.SetValue("GENRE", $"taunt{nooftaunts}", "");
                nooftaunts++;
            }
            nooftaunts = 1;
            //GAMERUN section
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
            //GAMEMULTIPLAYER section
            cfg.SetValue("GAMEMULTIPLAYER", "multiplayergame", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "gameobjectivetype", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "gameobjectivevalue", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "oneshotkills", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "maxplayers", 0);
            cfg.SetValue("GAMEMULTIPLAYER", "spawnrandom", 1);
            cfg.SetValue("GAMEMULTIPLAYER", "uniquegamecode",uniquegamecode);

            //GAMEDEBUG section
            cfg.SetValue("GAMEDEBUG", "height", 1020);
            cfg.SetValue("GAMEDEBUG", "width", 1980);
            cfg.SetValue("GAMEDEBUG", "depth", 32);
            cfg.SetValue("GAMEDEBUG", "usesky", 1);
            cfg.SetValue("GAMEDEBUG", "usefloor", 0);
            cfg.SetValue("GAMEDEBUG", "useenvsounds", 1);
            cfg.SetValue("GAMEDEBUG", "useweapons", 1);

            //GAMEPROFILE section
            cfg.SetValue("GAMEPROFILE", "title", $"languagebank\\{language}\\gamebank\\mygame\\titlepage.fpi");
            cfg.SetValue("GAMEPROFILE", "global", $"languagebank\\{language}\\gamebank\\mygame\\setuplevel.fpi");
            cfg.SetValue("GAMEPROFILE", "gamewon", $"languagebank\\{language}\\gamebank\\mygame\\gamewon.fpi");
            cfg.SetValue("GAMEPROFILE", "gameover", $"languagebank\\{language}\\gamebank\\mygame\\gameover.fpi");
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
            while (nooftaunts <= 30)
            {
                cfg.SetValue("GENRE", $"taunt{nooftaunts}", "");
                nooftaunts++;
            }
            int slot = 1;
            while (slot <= 9)
            {
                cfg.SetValue("GAMEPROFILE", $"slot{slot}", "");
                slot++;
            }
            /* Well be added later for lading maps and leading screens  
            cfg.Save();
            int level = 1;
            cfg.SetValue("GAMEPROFILE", "levelmax", nroflevels);
            do
            {
                cfg.SetValue("GAMEPROFILE", $"levelfpm{level}", $"mapbank\\horrorgame\\{level}.fpm");
                /*Set the loading screen
                cfg.SetValue("GAMEPROFILE", $"levelfpi{level}", $"mapbank\\horrorgame\\{level}.fpm");*/
            //}
            // while (level <= nroflevels);
            //saveall settings*/

            setdefault();
        }


        void checkfileexistance(string filename)
        {
            if (!File.Exists(configpath))
            {
                createnewini(configpath);
            }
        }

        void loadvalue()

        {
            var cfg = new ConfigParser(configpath);
            LoadedResolution = cfg.GetValue("GAMEDEBUG", "width") + "x" + cfg.GetValue("GAMEDEBUG", "height");

            //Keys

            LoadedForwardKey = cfg.GetValue("GAMEPROFILE", "key1");
            LoadedBackwardKey = cfg.GetValue("GAMEPROFILE", "key2");
            LoadedLeftKey = cfg.GetValue("GAMEPROFILE", "key3");
            LoadedRightKey = cfg.GetValue("GAMEPROFILE", "key4");
            LoadedJumpKey = cfg.GetValue("GAMEPROFILE", "key5");
            LoadedCrouchKey = cfg.GetValue("GAMEPROFILE", "key6");
            LoadedUseKey = cfg.GetValue("GAMEPROFILE", "key7");
            LoadedReloadKey = cfg.GetValue("GAMEPROFILE", "key8");
            LoadedPeekLeftKey = cfg.GetValue("GAMEPROFILE", "key9");
            LoadedPeekRightKey = cfg.GetValue("GAMEPROFILE", "key10");
            LoadedSprintKey = cfg.GetValue("GAMEPROFILE", "key11");

            //setting keys

            if (CrouchKey != null ||
                ForwardKey != null ||
                BackwardKey != null ||
                LeftKey != null ||
                RightKey != null ||
                JumpKey != null ||
                UseKey != null ||
                ReloadKey != null ||
                PeekLeftKey != null ||
                PeekRightKey != null ||
                Textures_Quality != null ||
                Resolution_Selector != null ||
                SprintKey != null ||
                LoadedResolution != null)
                setkeys();
            else
            {
                setdefault();
            }

        }

        void savevalue()
        {//check if any value is null
            try
            {
                Resolution = Resolution_Selector.Text;
                Reso_Height = Resolution.Split(delimiter)[1];
                Reso_Width = Resolution.Split(delimiter)[0];
                CrouchKey = keyboardLayout[Crouch.Text].ToString();
                ForwardKey = keyboardLayout[Forward.Text].ToString();
                BackwardKey = keyboardLayout[Backward.Text].ToString();
                LeftKey = keyboardLayout[Left_Dropdown.Text].ToString();
                RightKey = keyboardLayout[Right_Dropdown.Text].ToString();
                JumpKey = keyboardLayout[Jump.Text].ToString();
                SprintKey = keyboardLayout[Sprint.Text].ToString();
                UseKey = keyboardLayout[Useaction.Text].ToString();
                ReloadKey = keyboardLayout[Reload.Text].ToString();
                PeekLeftKey = keyboardLayout[PeekLeft.Text].ToString();
                PeekRightKey = keyboardLayout[Peekright.Text].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error, please try again. If the problem still persists, use the default settings.");
            }

            if (CrouchKey == null ||
                ForwardKey == null ||
                BackwardKey == null ||
                LeftKey == null ||
                RightKey == null ||
                JumpKey == null ||
                UseKey == null ||
                ReloadKey == null ||
                PeekLeftKey == null ||
                PeekRightKey == null ||
                Textures_Quality == null ||
                Resolution_Selector == null ||
                SprintKey == null)

                MessageBox.Show("Please make sure all settings are set before saving.");

            else
            {
                //Saving configuration

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
                    cfg.SetValue("GAMEPROFILE", "key11", SprintKey);
                    cfg.SetValue("GAMEDEBUG", "width", Reso_Width);
                    cfg.SetValue("GAMEDEBUG", "height", Reso_Height);
                    cfg.Save();

                    
                    Savesucess = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("There is an error, please try again. If the problem still persists, use the default settings.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            //if file exist 
            //loadvalue();
            //if not exist, create one with default values
            //code goes here
            checkfileexistance(configpath);





        }


        private void button1_Click(object sender, EventArgs e)

        { }





        //Forward Ket dropdown

        private void Forward_SelectedValueChanged(object sender, EventArgs e)

        {

            ForwardKey = keyboardLayout[Forward.Text].ToString();



        }


        //Backward Key dropdown



        private void Save_Click(object sender, EventArgs e)
        {
            //Save button
            try
            {
                var cfg = new ConfigParser(configpath);

            savevalue();
            MessageBox.Show("Setting saved.");

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


        private void Reset_Click(object sender, EventArgs e)
        {
            setdefault();
        }


    }
}

