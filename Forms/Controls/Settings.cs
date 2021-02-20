using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Slurp_Juice_.Main;

namespace Slurp_Juice_.Forms.Controls
{
    public partial class Settings : UserControl
    {

        public Settings()
        {
            InitializeComponent();
        }

        private void topMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var Form = new Main();
            if (topMostCheckBox.Checked)
            {
                Main.ActiveForm.TopMost = true;
            }
            else
            {
                Main.ActiveForm.TopMost = false;
            }
        }
    }
}
