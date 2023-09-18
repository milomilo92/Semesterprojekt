using System;
using System.Xml.Serialization;

namespace ContactManager_ZBW.Model
{
    // Class Person
    // description: This is the class person
    // 
    [XmlInclude(typeof(Customer))]
    [XmlInclude(typeof(Employee))]
    [Serializable]
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
        // Compares all Fileds between two Persons
        public bool Equals(Person other)
        {
            if (other != null &&
                (Salutation == "" || other.Salutation == Salutation) &&
                (FirstName == "" || other.FirstName == FirstName) &&
                (LastName == "" || other.LastName == LastName) &&
                (other.DateOfBirth == DateOfBirth) &&
                (other.Gender == Gender) &&
                (Title == "" || other.Title == Title) &&
                (SocialSecurityNumber == "" || other.SocialSecurityNumber == SocialSecurityNumber) &&
                (PhoneNumberPrivat == "" || other.PhoneNumberPrivat == PhoneNumberPrivat) &&
                (PhoneNumberMobile == "" || other.PhoneNumberMobile == PhoneNumberMobile) &&
                (PhoneNumberBusiness == "" || other.PhoneNumberBusiness == PhoneNumberBusiness) &&
                (Email == "" || other.Email == Email) &&
                (Nationality == "" || other.Nationality == Nationality) &&
                (Street == "" || other.Street == Street) &&
                (StreetNumber == "" || other.StreetNumber == StreetNumber) &&
                (other.ZipCode == ZipCode || ZipCode == 0) &&
                (Place == "" || other.Place == Place))
            {
                return true;
            }
            return false;
        }


    }


}
