//none of the threaded functions work. probably due to the api itself not being threaded or something. not sure.
using Slurp_Juice_.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Slurp_Juice_.Forms.Controls.Injector;
using EasyExploits;
using System.Threading;

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

        public static void AttachThread()
        {
            Thread thread = new Thread(Attach);
        }

        public static void InjectLUA()
        {
            api.ExecuteScript(scriptstring);
        }

        public static void InjectThread()
        {
            Thread thread = new Thread(InjectLUA);
        }
    }
}
