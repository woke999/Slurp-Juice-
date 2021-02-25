using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Slurp_Juice_.Main;

namespace Slurp_Juice_.Handler
{
    public static class UI
    {
        public static bool HomeControl;
        public static bool InjectorControl;
        public static bool SettingsControl;
        public static bool ThemeControl;

        //reset all of the bools, the program checks bools often for the discord presence, so when you open a new control you reset the bools and then set which one is opened
        public static void ResetBools()
        {
            HomeControl = false;
            InjectorControl = false;
            SettingsControl = false;
			ThemeControl = false;
        }

        public static void Home()
        {
            HomeControl = true;
        }

        public static void Injector()
        {
            InjectorControl = true;
        }

        public static void Settings()
        {
            SettingsControl = true;
        }

        public static void Theme()
        {
            ThemeControl = true;
        }

        //theme manager code below//
        public static void SlurpTheme()
        {
            var Form = new Main();
        }

        public static void DarkTheme()
        {
            Color Black= Color.Black;

            var Form = new Main();
            //Form.ActiveControl.ForeColor = Black;
            Form.exitBtn.FillColor = Black;
            Form.exitBtn.BackColor = Black;
            Form.exitBtn.BorderColor = Black;
            Form.exitBtn.FillColor = Black;
            Form.exitBtn.PressedColor = Black;
            Form.miniBtn.FillColor = Black;
            Form.miniBtn.BackColor = Black;
            Form.miniBtn.BorderColor = Black;
            Form.miniBtn.FillColor = Black;
            Form.miniBtn.PressedColor = Black;
            //
        }
    }
}
