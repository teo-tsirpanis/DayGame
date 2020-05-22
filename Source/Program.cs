using System;
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


            var sf = StartUpMenu.ChooseSaveFile();
            if (sf != null)
               Application.Run(new NavigationMenu(sf));
            // Application.Run(new BossBattleFrame(sf.Character, sf.Inventory, new Boss("bosss", null, 45, 3, 6)));
        }
    }
}
