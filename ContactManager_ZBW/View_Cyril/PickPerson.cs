using ContactManager_ZBW.Milos.Controller;
using System;
using System.Windows.Forms;

namespace ContactManager_ZBW.View_Cyril
{
    public partial class PickPerson : Form
    {
        private Controller controller = new Controller();

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
