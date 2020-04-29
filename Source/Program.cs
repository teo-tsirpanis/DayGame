using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #if NETCOREAPP3_1
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            #endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new StartUpMenu());

        }
    }
}
