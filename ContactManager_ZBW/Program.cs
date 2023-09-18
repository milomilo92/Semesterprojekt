using ContactManager_ZBW.SupportController;
using ContactManager_ZBW.View;
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
