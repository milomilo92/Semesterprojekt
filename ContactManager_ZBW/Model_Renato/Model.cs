using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager_ZBW.Model_Renato
{
    internal class Model
    {

        // This is the class Person.
        class Person
        {
            public string Salutation { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public bool Gender { get; set; }
            public string Title { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string PhoneNumberPrivat { get; set; }
            public string PhoneNumberMobile { get; set; }
            public string PhoneNumberBusiness { get; set; }
            public string Email { get; set; }
            public bool Status { get; set; }
            public string Nationality { get; set; }
            public string Street { get; set; }
            public string StreetNumber { get; set; }
            public int ZipCode { get; set; }
            public string Place { get; set; }
        }

        // This is the Customer class which inherits from the Person class
        class Customer : Person
        {
            public string CompanyName { get; set; }
            public char CustomerType { get; set; }
            public string CompanyContact { get; set; }
        }
        // This is the Employee class which inherits from the Person class
        class Employee : Person
        {
            public Guid EmployeeNumber { get; set; }
            public string Department { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int Employment { get; set; }
            public string Role { get; set; }
            public int CadreLevel { get; set; }
        }
        // This is the Trainee class which inherits from the Person class
        class Trainee : Person
        {
            public int TraineeYears { get; set; }
            public int ActualTraineeYear { get; set; }
        }
    }
}
