using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Slurp_Juice_.Main;

namespace Slurp_Juice_.Handler
{
    public static class UI
    {
        public static void ResetBools()
        {
            HomeControl = false;
            InjectorControl = false;
            SettingsControl = false;
        }

        public static void Home()
        {
            HomeControl = true;
        }

        public static void Injector()
        {
            InjectorControl = false;
        }

        public static void Settings()
        {
            SettingsControl = true;
        }
    }
}
