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
            // Fill in all the Persons of the PersonsList into the ListBox
            throw new NotImplementedException();
            // soll hier schon geladen werden?
            LoadList();
        }
        
        // Function CmdNew_Click
        // description: creates a new Person and adds it to the list
        private void CmdNew_Click(object sender, EventArgs e)
        {
            if (CheckNecessaryFields()) // only when necessary Fields are entered
            {
                    Person temporaryPerson = CreateCustomerOrEmployee();
                    FillAllFields(temporaryPerson);
                    int index = CreateNewPerson(temporaryPerson);
                    LslContactList.SelectedIndex = index;  // select and show newly created person         
            }             
        }

        // Function CmdUpdate_Click
        // description: after a Person is selected, its specs can be altered with this function
        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            if (LslContactList.SelectedIndices.Count > 0) {
                if (CheckNecessaryFields()) // only when necessary Fields are entered
                {
                    {
                        int index = LslContactList.SelectedIndex;
                        Person temporaryPerson = CreateCustomerOrEmployee();
                        FillAllFields(temporaryPerson);
                        bool result = UpdatePerson(index, temporaryPerson);
                    }
                }
                else
                {
                    MessageBox.Show("Bitte erst zu ändernde Person auswählen oder suchen");
                }
            }
        }

        // Function CmdSearch_Click
        // description: a search in the person list will be performed based on the entered fields
        private void CmdSearch_Click(object sender, EventArgs e)
        {
            if (CheckNecessaryFields()) // only when necessary Fields are entered
            {
                Person temporaryPerson = CreateCustomerOrEmployee();
                FillAllFields(temporaryPerson);
                int index = SearchPerson(temporaryPerson);
                if (index != -1)
                {
                    LslContactList.SelectedIndex = index;   // select and show found person
                }
                else
                {
                    MessageBox.Show("Keine entsprechende Person gefunden.");
                }
            }
        }

        // Function CmdDelete_Click
        // description: the selected person will be removed from the list
        private void CmdDelete_Click(object sender, EventArgs e)
        {

                if (LslContactList.SelectedIndices.Count > 0)
                {
                    throw new NotImplementedException; // Noch Abfragefenster programmieren!
                    int index = LslContactList.SelectedIndex;
                    bool result = DeletePerson(index);
                }
                else
                {
                    MessageBox.Show("Keine Person zum Löschen ausgewählt.");
                }            
        }

        // Function CmdSave_Click
        // description: the persons in the list will be saved to file
        private void CmdSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            // wie heisst die Funktion von Ramon?
        }

        // Function CmdLoad_Click
        // description: the list will be filled with data from file
        private void CmdLoad_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            // wie heisst die Funktion von Ramon?
        }


        // Function LslContactList_SelectedIndexChanged
        // description: when a person is selected in the list, its data will be shown in the view
        private void LslContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LslContactList.SelectedIndices.Count !=0 && LslContactList.SelectedIndices.Count < 2)
            {
                int selectedIndex = LslContactList.SelectedIndex;
                Person selectedPerson = GetPerson(selectedIndex);
                ShowAllFields(selectedPerson);
            }
        }

        // Function CreateCustomerOrEmployee
        // description: depending on selected Person type in view, returns the according correct type
        private Person CreateCustomerOrEmployee()
        {
            Person temporaryPerson;

            if (TabControl.SelectedTab.Name == "TbCustomer")
            {
                temporaryPerson = new Customer;
            }
            else // if (TabControl.SelectedTab.Name == "TbEmployee")
            {
                temporaryPerson = new Employee;
            }
            return temporaryPerson;
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
        }

        // Function FillAllFields
        // description: fills all the fields of the view into the Person object
        private void FillAllFields (Person person)
        {
            // fill all base fields of the person:
            person.Salutation = RdSalutationsFemale.Checked ? "Frau" : "Herr";
            person.FirstName = TxtFirstName.Text;
            person.LastName = TxtLastName.Text;
            person.DateOfBirth = DtpDateOfBirth.Value;
            //person.Gender =  to be defined in View!
            //person.Title =  to be defined in View!
            person.SocialSecurityNumber = TxtSocialSecurityNumber.Text;
            person.PhoneNumberPrivat = TxtPhoneNumberPrivate.Text;
            person.PhoneNumberMobile = TxtPhoneNumberMobile.Text;
            person.PhoneNumberBusiness = TxtPhoneNumberBusiness.Text;
            person.Email = TxtEmail.Text;
            person.Status = RdActive.Checked;
            //person.Nationality =  to be defined in View!
            person.Street = TxtStreet.Text;
            person.StreetNumber = TxtStreetNumber.Text;
            person.Place = TxtPlace.Text;
            try
            {
                person.ZipCode = Convert.ToInt16(TxtZipCode.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nur Zahlen in PLZ erlaubt");
            }

            // aditionally fill out all customer or employee fields into the Person object
            throw new NotImplementedException();
        }

        // Function ShowAllFields
        // description: shows all the fields of a person in the view
        private void ShowAllFields(Person person)
        {
            // show all base fields of the person:
            RdSalutationsFemale.Checked = person.Salutation=="Frau"? true :false;
            TxtFirstName.Text = person.FirstName;
            TxtLastName.Text = person.LastName;
            DtpDateOfBirth.Value = person.DateOfBirth;
            // tbd in View! = person.Gender;
            // tbd in View! = person.Title;
            TxtSocialSecurityNumber.Text = person.SocialSecurityNumber;
            TxtPhoneNumberPrivate.Text = person.PhoneNumberPrivat;
            TxtPhoneNumberMobile.Text = person.PhoneNumberMobile;
            TxtPhoneNumberBusiness.Text = person.PhoneNumberBusiness;
            TxtEmail.Text = person.Email;
            RdActive.Checked = person.Status;
            // tbd in View! = person.Nationality;
            TxtStreet.Text = person.Street;
            TxtStreetNumber.Text = person.StreetNumber;
            TxtZipCode.Text = Convert.ToString(person.ZipCode);
            TxtPlace.Text = person.Place;

            // additionally show all customer or employee fields in View
            throw new NotImplementedException();
        }

        private void LoadList()
        {
            LslContactList.Items.Clear();
            string[] allPersonData = GetAllPersonData();
            foreach (string personData in allPersonData)
            {
                LslContactList.Items.Add(personData);
            }
        }

    }
}
