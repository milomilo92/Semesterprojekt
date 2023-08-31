using ContactManager_ZBW.Model_Renato;
using ContactManager_ZBW.Ramon;
using ContactManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;



namespace ContactManager_ZBW.Milos.Controller
{
    
    public class Controller

        
    {
        // List with all people related entries

        
        private List<Person> people = new List<Person>();

        // User credentials in clear text for demonstration
        private string[,] userCredentials = {
            {"user", "1234"},
            {"larissa", "12345"},
            {"admin", "123456"}
        };

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
            if (index != -1)
            {
                people[index] = temporaryPerson;
            }
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
                people.RemoveAt(index);
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

        public bool CheckUserCredentials(string enteredUsername, string enteredPassword)
        {
            // Authentification check
            bool isAuthenticated = false;
            // For-loop to check user credentials with infinite tries. If correct, loop breaks
            for (int i = 0; i < userCredentials.GetLength(0); i++)
            {
                if (enteredUsername == userCredentials[i, 0] && enteredPassword == userCredentials[i, 1])
                {
                    isAuthenticated = true;
                    break;
                }
            }
            return isAuthenticated;
        }

        public int KeyNavigation(KeyEventArgs e)
        {
            // If user hits enter key, return 1".
            if (e.KeyCode == Keys.Enter)
            {
                return 1;
            }
            // If user hits esc key, return 2.
            else if (e.KeyCode == Keys.Escape)
            {
                return 2;
            }
            // In every other case, return 0, which doesn't create any event.
            else
            {
                return 0;
            }
        }

        // Dummy Funktion für Dateinen
        // bitte namen der Funktion so beibehalten

        public void LoadData() 
        {
          string filePath = "peopleList.txt";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using (TextReader reader = new StreamReader(filePath))
            {
                people = (List<Person>)serializer.Deserialize(reader);
            }


            // Ramon 
        }

        public void SaveData()
        {
            string filePath = "peopleList.txt";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, people);
            }
                
                       
        }


    }


}
