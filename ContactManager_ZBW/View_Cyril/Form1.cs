﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager_ZBW.Milos.Controller;
using ContactManager_ZBW.Model_Renato;


namespace ContactManager
{
    public partial class Form1 : Form
    {
        private Controller controller;
        ArrayList people;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ArrayList people = new ArrayList();
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
                    int index = controller.CreateNewPerson(temporaryPerson, people);
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
                        UpdatePerson(index, temporaryPerson);
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
                    ClearView();
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
                ClearView();
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
                if (RdTraineeYes.Checked)
                {
                    temporaryPerson = new Trainee;
                }
                else
                {
                    temporaryPerson = new Employee;
                }
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
            switch (TabControl.SelectedTab.Name)
            {
                case "TbCustomer":
                    ((Customer)person).CompanyName = TxtCompanyName.Text;
                    ((Customer)person).CustomerType = TxtCustomerType.Text;
                    ((Customer)person).CompanyContact = TxtCompanyContact.Text;
                    break;
                case "TbEmployee":
                    ((Employee)person).Department = TxtDepartment.Text;
                    ((Employee)person).Role = TxtRole.Text;
                    ((Employee)person).StartDate = DtpStartDate.Value;
                    ((Employee)person).EndDate = DtpEndDate.Value;
                    try
                    {
                        ((Employee)person).Employment = Convert.ToInt16(TxtEmployment.Text);
                        ((Employee)person).CadreLevel = Convert.ToInt16(TxtCadreLevel.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Beschäftigungsgrad und Kaderstufe dürfen nur Nummern sein.");                        
                    }
                    // also get trainee data if neccessary:
                    if (RdTraineeYes.Checked)
                    {
                        try
                        {
                            ((Trainee)person).ActualTraineeYear = Convert.ToInt16(TxtActualTraineeYear.Text);
                            ((Trainee)person).TraineeYears = Convert.ToInt16(TxtTraineeYears.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Lehrjahre und aktuelles Lehrjahr dürfen nur Zahlen sein.");                                                        
                        }
                    }                                     
                    break;
                default:
                    break;
            }
            // additionally fill out trainee data:
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

            // additionally show all customer or employee fields in view:
            if (person is Customer)
            {
                TxtCompanyName.Text = ((Customer)person).CompanyName;
                TxtCustomerType.Text = ((Customer)person).CustomerType;
                TxtCompanyContact.Text = ((Customer)person).CompanyContact;

                // add all log entries to the log history in the view:
                TxtLogHistory.Clear();           // first empty the history
                string[] logEntries = ((Customer)person).GetAllLogEntries();
                foreach (string entry in logEntries)
                {
                    TxtLogHistory.Text += entry + "\r\n";
                }
            }
            // additionally show all employee fields in the view:
            else if (person is Employee)
            {
                TxtDepartment.Text = ((Employee)person).Department;
                TxtRole.Text = ((Employee)person).Role;
                DtpStartDate.Value = ((Employee)person).StartDate;
                DtpEndDate.Value = ((Employee)person).EndDate;
                TxtEmployment.Text = Convert.ToString( ((Employee)person).Employment );
                TxtCadreLevel.Text = Convert.ToString( ((Employee)person).CadreLevel );

                //additionally show all trainee fields in the view:
                if (person is Trainee)
                {
                    TxtTraineeYears.Text = ((Trainee)person).TraineeYears;
                    TxtActualTraineeYear.Text = ((Trainee)person).ActualTraineeYear;
                }
            }

        }

        // Function LoadList
        // description: Fills all persons from the the controllers list to the ListBox
        private void LoadList()
        {
            LslContactList.Items.Clear();
            string[] allPersonData = GetAllPersonData();
            foreach (string personData in allPersonData)
            {
                LslContactList.Items.Add(personData);
            }
        }

        // Function ClearView()
        // description: resets all the fields in the view and deselects the ListBox
        private void ClearView()
        {
            Person emptyPerson = CreateCustomerOrEmployee();
            ShowAllFields(emptyPerson);
            LslContactList.ClearSelected();  // nothing shall be selected in the ListBox
        }

        // Function CmdLogAdd_Click
        // description: adds a log entry to the logEntry-array of the customer
        private void CmdLogAdd_Click(object sender, EventArgs e)
        {
            if (LslContactList.SelectedIndices.Count > 0)
            {
                int index = LslContactList.SelectedIndex;
                Customer customer = GetPerson(index);
                string newLogEntry = TxtLogNew.Text;
                if (newLogEntry != "")
                {
                    // Noch über Controller machen, nicht direkt im Model.
                    throw new NotImplementedException() // Noch index und so machen;
                    controller.AddLogEntry(index, newLogEntry);
                }
                UpdatePerson(customer);                 // Update new data to controllers customer-list
                TxtLogNew.Clear();                      // and clear entry field
                LslContactList.SelectedIndex = index;   // finally update view and show entry in list
                else
                {
                    MessageBox.Show("Keine leeren Logeinträge erlaubt.");
                }
            }
            else
            {
                MessageBox.Show("Bitte erst einen Kunden auswählen.");
            }
        }
    }
}
