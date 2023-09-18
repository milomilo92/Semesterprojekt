using ContactManager_ZBW.Milos.Controller;
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
        private Controller Controller = new Controller();

        public Login()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            // Get strings from view and transfer to controller. Controller returns bool value
            string enteredUsername = TxtUsername.Text;
            string enteredPassword = TxtPassword.Text;
            bool isAuthenticated = Controller.CheckUserCredentials(enteredUsername, enteredPassword);
            CheckUserAuthentication(isAuthenticated);
        }

        private void CheckUserAuthentication(bool isAuthenticated)
        {
            if (isAuthenticated)
            {
                // If user credentials are correct, DialogResult changes to OK, login closes.
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
            int enteredKey = Controller.KeyNavigation(e);

            // If user hits enter key, it will act like pressing the "login-button".
            if (enteredKey == 1)
            {
                CmdLogin_Click(sender, e);
            }
            // If user hits esc key, it will act like closing the window.
            else if (enteredKey == 2)
            {
                this.Close();
            }
        }

    }

}
