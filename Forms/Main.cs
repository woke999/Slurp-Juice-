using Slurp_Juice_.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slurp_Juice_.Handler;
using System.Threading;

namespace Slurp_Juice_
{
    public partial class Main : Form
    {
        public static string Version = "1.1";

        public Main()
        {
            InitializeComponent();
            apiLabel.Text = "Not attached";
            Discord.DiscordID();
            Discord.DiscordStart();
            SlurpConsole.AllocConsole();
            SlurpConsole.Welcome();
        }

        public void Main_Load(object sender, EventArgs e)
        {
            var Form = new Main();
            UI.Home();
            versionLabel.Text = Version;
            var Home = new Forms.Controls.Home();
            controlPanel.Controls.Add(Home);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Discord.ShutDown();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            UI.ResetBools();
            UI.Home();
            Discord.Update();
            controlPanel.Controls.Clear();
            var Home = new Forms.Controls.Home();
            controlPanel.Controls.Add(Home);
        }

        private void injectorBtn_Click(object sender, EventArgs e)
        {
            UI.Injector();
            UI.ResetBools();
            UI.Injector();
            Discord.Update();
            controlPanel.Controls.Clear();
            var Injector = new Forms.Controls.Injector();
            controlPanel.Controls.Add(Injector);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            UI.ResetBools();
            UI.Settings();
            Discord.Update();
            controlPanel.Controls.Clear();
            var Settings = new Forms.Controls.Settings();
            controlPanel.Controls.Add(Settings);
        }

        private void themeBtn_Click(object sender, EventArgs e)
        {
            UI.ResetBools();
            UI.Theme();
            Discord.Update();
            controlPanel.Controls.Clear();
            var Theme = new Forms.Controls.Theme();
            controlPanel.Controls.Add(Theme);
        }

        //this has to be threaded because loading the editor files can cause freezing, so put it on another thread :pog:
        //threading makes it not load lolz :pog: plz someone fix this for me 
        //for now it may freeze
        private void InjectorThread()
        {
            Thread thread = new Thread(InjectBtnFunction);
        }

        private void InjectBtnFunction()
        {
            UI.Injector();
            UI.ResetBools();
            UI.Injector();
            Discord.Update();
            controlPanel.Controls.Clear();
            var Injector = new Forms.Controls.Injector();
            controlPanel.Controls.Add(Injector);
        }
    }
}
