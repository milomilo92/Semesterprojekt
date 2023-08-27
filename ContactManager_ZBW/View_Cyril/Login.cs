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
        // User credentials in clear text for demonstration
        private string[,] userCredentials = {
            {"user", "1234"},
            {"larissa", "12345"},
            {"admin", "123456"}
        };

        public Login()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            // Get strings from view
            string enteredUsername = TxtUsername.Text;
            string enteredPassword = TxtPassword.Text;
            // Authentification check
            bool isAuthenticated = false;

            // For-loop to check user credentials with infinite tries. If correct, loop breaks
            for (int i = 0; i < userCredentials.GetLength(0); i++)
            {
                if (enteredUsername == userCredentials[i, 0] && enteredPassword == userCredentials[i, 1])
                {
                    isAuthenticated = true;
                    CheckUserCredentials(isAuthenticated);
                    break;
                }
            }
            CheckUserCredentials(isAuthenticated);
        }

        private void CheckUserCredentials(bool isAuthenticated)
        {
            if (isAuthenticated)
            {
                // If user credentials are correct, textbox appears. DialogResult changes to OK, login closes.
                MessageBox.Show("Anmeldung erfolgreich! Das Programm wird geladen.");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // If user credentials are wrong,textbox appears and password field gets cleared.
                MessageBox.Show("Falscher Benutzername oder Passwort. Bitte erneut versuchen.");
                TxtPassword.Clear();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            // If user hits enter key, it will act like pressing the "login-button".
            if (e.KeyCode == Keys.Enter)
            {
                CmdLogin_Click(sender, e);
            }
            // If user hits esc key, it will act like closing the window.
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }

}
