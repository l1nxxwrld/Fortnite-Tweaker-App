using System;
using Squirrel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite_Chapter_3_Tweaker
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Welcome());
            }
            









        }

        private static async Task CheckForUpdates()
        {
            using (var mgr = new UpdateManager(@"C:\Users\micha\source\repos\Fortnite Chapter 3 Tweaker\Relases"))
            {
                await mgr.UpdateApp();
            }
        }
    }
}
