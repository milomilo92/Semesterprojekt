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
    public partial class Search : Form
    {
        private Controller Controller = new Controller();

        public Search()
        {
            InitializeComponent();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            int enteredKey = Controller.KeyNavigation(e);

            // If user hits enter key, it will act like pressing the "search-button".
            if (enteredKey == 1)
            {
                CmdSearch_Click(sender, e);
            }
            // If user hits esc key, it will act like closing the window.
            else if (enteredKey == 2)
            {
                this.Close();
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {

        }

        private void CmdOk_Click(object sender, EventArgs e)
        {

        }
    }
}
