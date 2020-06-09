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
        static int Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                ItemRegistry.Initialize("Items/items.json");
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    $"Error during start-up: {e.Message}\nPlease install DayGame again and open a GutHub issue if the problem persists.",
                    "System error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            var sf = StartUpMenu.ChooseSaveFile();
            if (sf != null)
                Application.Run(new NavigationMenu(sf));
            // Application.Run(new BossBattleFrame(sf.Character, sf.Inventory, new Boss("bosss", null, 45, 3, 6)));
            return 0;
        }
    }
}
