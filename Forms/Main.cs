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

namespace Slurp_Juice_
{
    public partial class Main : Form
    {
        public static string Version = "1.0";

        public Main()
        {
            InitializeComponent();
            apiLabel.Text = "Not attached";
            Discord.DiscordID();
            Discord.DiscordStart();
            SlurpConsole.AllocConsole();
            SlurpConsole.Welcome();
        }

        private void Main_Load(object sender, EventArgs e)
        {
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
            Discord.Update();
            controlPanel.Controls.Clear();
            var Home = new Forms.Controls.Home();
            controlPanel.Controls.Add(Home);
        }

        private void injectorBtn_Click(object sender, EventArgs e)
        {
            Discord.Update();
            controlPanel.Controls.Clear();
            var Injector = new Forms.Controls.Injector();
            controlPanel.Controls.Add(Injector);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Discord.Update();
            controlPanel.Controls.Clear();
        }
    }
}
