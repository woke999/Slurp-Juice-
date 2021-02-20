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
using static Slurp_Juice_.Handler.Inject;

namespace Slurp_Juice_.Forms.Controls
{
    public partial class Injector : UserControl
    {
        public static bool attached = false;
        public static string scriptstring;
        OpenFileDialog open = new OpenFileDialog();

        public Injector()
        {
            InitializeComponent();
        }

        private void Injector_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Format("file:///{0}ace/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.apiLabel.Text = "Attached";
            SlurpConsole.Update();
            Discord.Update();
            Inject.Check();
            Inject.Attach();
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            Discord.Update();
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            scriptstring = script;
            Inject.InjectLUA();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            Discord.OpenState();
            open.Filter = "Lua File|*.lua";
            open.Title = "Open a script";
            if (open.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(open.FileName);
                webBrowser1.Document.InvokeScript("SetText", new object[]
                {
                    reader.ReadToEnd()
                });
                Discord.Update();
                reader.Close();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
