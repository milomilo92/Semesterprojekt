using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager_ZBW.View_Cyril
{
    public partial class Login : Form
    {

        private string[,] userCredentials = {
            {"user", "1234"},
            {"admin", "123456"}
        };

        public Login()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = TxtUsername.Text;
            string enteredPassword = TxtPassword.Text;
            bool isAuthenticated = false;

            for (int i = 0; i < userCredentials.GetLength(0); i++)
            {
                if (enteredUsername == userCredentials[i, 0] && enteredPassword == userCredentials[i, 1])
                {
                    isAuthenticated = true;
                    break;
                }
            }

            if (isAuthenticated)
            {
                MessageBox.Show("Anmeldung erfolgreich! Das Programm wird geladen.");
                // Wie bringen wir den Load weiter, damit die Hauptview geladen wird?
            }
            else
            {
                MessageBox.Show("Falscher Benutzername oder Passwort. Bitte erneut versuchen.");
            }
        }
    }

}
