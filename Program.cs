﻿using System;
using System.Windows.Forms;

namespace FitnessReminder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSettings((Args.Length > 0) && Args[0].Contains("/auto")));
        }
    }
}
