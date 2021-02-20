using Slurp_Juice_.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Slurp_Juice_.Forms.Controls.Injector;
using EasyExploits;

namespace Slurp_Juice_.Handler
{
    public static class Inject
    {
        public static EasyExploits.Module api = new EasyExploits.Module();

        public static void Check()
        {
            if (Injector.attached == true)
            {
                MessageBox.Show("Lua API already attached","Slurp Juice");
            }
            else
            {

            }
        }

        public static void Attach()
        {
            Injector.attached = true;
            api.LaunchExploit();
        }

        public static void InjectLUA()
        {
            api.ExecuteScript(scriptstring);
        }
    }
}
