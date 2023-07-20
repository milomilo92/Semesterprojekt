using Aufgabe_A12_1_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager_ZBW.Model_Renato
{
    // Class Person
    // description: This is the class person
    public class Person
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



        // Methode Equals(Person):bool
        // 
        public bool Equals(Person other)
        {
            if (other != null &&
                other.Salutation == Salutation &&
                other.FirstName == FirstName &&
                other.LastName == LastName &&
                other.DateOfBirth == DateOfBirth)
            {
                return true;
            }
            return false;
        }

            }


}
