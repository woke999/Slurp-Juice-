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

namespace Slurp_Juice_.Forms.Controls
{
    public partial class Theme : UserControl
    {
        public Theme()
        {
            InitializeComponent();
        }

        private void slurpThemeBtn_Click(object sender, EventArgs e)
        {

        }

        private void blackThemeBtn_Click(object sender, EventArgs e)
        {
            UI.DarkTheme();
        }
    }
}
