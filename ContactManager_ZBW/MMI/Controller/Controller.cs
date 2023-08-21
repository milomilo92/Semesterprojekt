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
        private Person person;
        private List<Person> people = new List<Person>();

        public static int CreateNewPerson(Person temporaryPerson)
        {
            int personId = Class1.SearchPersonId(temporaryPerson);

            if (personId >= 0) 
            {
                return -1; // if person already exists
            }
            else
            {
                personId = Person.Add(temporaryPerson); // int person add --> int wird zurückgegeben, das wird der Index nach dem Speichern
                // personId = Class1.SearchPersonId(temporaryPerson, personList);
                return personId;
            }
        }

        public void UpdatePerson(int index, Person temporaryPerson)
        {
            // in der Liste bestehende Person überschreiben.

        }

        public int SearchPerson(Person temporaryPerson)
        {
            int personId = Class1.SearchPersonId(temporaryPerson);
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
            // Was soll das können?
        }
    }

}
