﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Slurp_Juice_.Forms.Controls.Injector;

namespace Slurp_Juice_.Handler
{
    public static class SlurpConsole
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();

        public static void Welcome()
        {
            Console.Title = $"Slurp Juice {Main.Version} Debug Console | Attached: {attached}";
        }

        public static void Update()
        {
            Console.Title = $"Slurp Juice {Main.Version} Debug Console | Attached: {attached}";
        }
    }
}
