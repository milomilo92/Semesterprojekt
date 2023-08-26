using ContactManager_ZBW.Model_Renato;
using ContactManager_ZBW.Ramon;
using ContactManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ContactManager_ZBW.Milos.Controller
{
    public class Controller
    {
        private List<Person> people = new List<Person>();

        public int CreateNewPerson(Person temporaryPerson)
        {
            int personId = Class1.SearchPersonId(temporaryPerson, people);

            if (personId >= 0) 
            {
                return -1; // if person already exists
            }
            else
            {
                people.Add(temporaryPerson);
                return people.Count() - 1;
            }
        }

        public void UpdatePerson(int index, Person temporaryPerson)
        {
            // in der Liste bestehende Person überschreiben.

        }

        public int SearchPerson(Person temporaryPerson)
        {
            int personId = Class1.SearchPersonId(temporaryPerson, people);
            return personId;
        }

        public void DeletePerson(int index)
        {
            if (index != -1)
            {
                // Person löschen
            }
        }

        public Person GetPerson(int index)
        {
            
            return people[index];
        }
        public string[] GetAllPersonData()
        {
            string[] nameList = new string[people.Count()];
            int count = 0;

            foreach (Person pers in people)
            {
                nameList[count] = pers.LastName + " " + pers.FirstName;
                count++;
            }

            return nameList;
        }

        public bool CheckCustomerType(char customerType)
        {
            int numberOfChar = customerType;
            if (numberOfChar >= 65 && numberOfChar <= 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Dummy Funktion für Dateinen
        // bitte namen der Funktion so beibehalten

        public void LoadData() 
        { 
        
        }
    }


}
