using System;
using System.IO;
using System.Diagnostics;
using System.Reflection;
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
            //Validates it's not already running.
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Length > 1)
            {
                //Show user a warning.
                MessageBox.Show(string.Format("Fitness Reminder is already running!", Environment.NewLine), "Fitness Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Exit program.
                return;
            }
            Application.Run(new FormSettings((Args.Length > 0) && Args[0].Contains("/auto")));
        }
    }
}
