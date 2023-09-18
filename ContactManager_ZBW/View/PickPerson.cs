using ContactManager_ZBW.Controller.Controller;
using System;
using System.Windows.Forms;

namespace ContactManager_ZBW.View
{
    public partial class PickPerson : Form
    {
        private Controller.Controller.Controller controller = new Controller.Controller.Controller();

        public int SelectedIndex
        {
            get { return LstShowMatchingPersons.SelectedIndex; }
            set { }
        }


        public PickPerson()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
