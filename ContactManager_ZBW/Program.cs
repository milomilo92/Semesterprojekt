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

            Login loginForm = new Login();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainView());
            }

        }
    }
}
