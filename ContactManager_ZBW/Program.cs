using ContactManager_ZBW.Ramon;
using ContactManager_ZBW.View_Cyril;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager_ZBW
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());


            // GitHub Test Cyril
            // GitHub Test Miloš
            // GitHub Test Renato+//lfi
            // nächster Test Renato

            // GitHub Test Ramon - hat nicht funktioniert :-)

            
        }
    }
}
