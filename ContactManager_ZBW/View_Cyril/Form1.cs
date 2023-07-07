using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager_ZBW.Model_Renato;


namespace ContactManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        // Function CmdNew_Click
        // description: creates a new Person and adds it to the list
        private void CmdNew_Click(object sender, EventArgs e)
        {
            if (CheckNecessaryFields()) // only when necessary Fields are entered
            {
                Person temporaryPerson = new Person();
                FillAllFields(temporaryPerson);
                CreateNewPerson(temporaryPerson);
            }             
        }

        // Function CmdUpdate_Click
        // description: after a Person is selected, its specs can be altered with this function
        private void CmdUpdate_Click(object sender, EventArgs e)
        {

        }

        // Function CmdSearch_Click
        // description: a search in the person list will be performed based on the entered fields
        private void CmdSearch_Click(object sender, EventArgs e)
        {

        }

        // Function CmdDelete_Click
        // description: the selected person will be removed from the list
        private void CmdDelete_Click(object sender, EventArgs e)
        {

        }

        // Function CmdSave_Click
        // description: the persons in the list will be saved to file
        private void CmdSave_Click(object sender, EventArgs e)
        {

        }

        // Function CmdLoad_Click
        // description: the list will be filled with data from file
        private void CmdLoad_Click(object sender, EventArgs e)
        {

        }

        // Function CheckNecessarFields
        // description: checks if all necessary fields are entered before actions
        private bool CheckNecessaryFields()
        {
            // Check if all necessary base fields are entered:
            if (TxtFirstName.Text != "" && TxtLastName.Text != "" && TxtEmail.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Bitte mindestens Name, Vorname und E-Mail ausfüllen");
                return false;
            }

            // Further check if all necessary customer fields are entered:
        }

        // Function FillAllFields
        // description: fills all the fields of the view into the Person object
        private void FillAllFields (Person person)
        {
            person.Salutation = RdSalutationsFemale.Checked;
            person.FirstName = TxtFirstName.Text;
            person.LastName = TxtLastName.Text;
            person.DateOfBirth = DtpDateOfBirth.Value;
            person.Gender = // to be defined in View!
            person.Title = // to be defined in View!
            person.SocialSecurityNumber = TxtSocialSecurityNumber.Text;
            person.PhoneNumberPrivat = TxtPhoneNumberPrivate.Text;
            person.PhoneNumberMobile = TxtPhoneNumberMobile.Text;
            person.PhoneNumberBusiness = TxtPhoneNumberBusiness.Text;
            person.Email = TxtEmail.Text;
            person.Status = RdActive.Checked;
            person.Nationality = // to be defined in View!
            person.Street = TxtStreet.Text;
            person.StreetNumber = TxtStreetNumber.Text;
            person.ZipCode = TxtZipCode.Text;
            person.Place = TxtPlace.Text;
        }
    }
}
