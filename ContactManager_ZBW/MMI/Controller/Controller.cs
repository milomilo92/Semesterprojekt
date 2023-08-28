﻿using ContactManager_ZBW.Model_Renato;
using ContactManager_ZBW.Ramon;
using ContactManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;




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

        // Dummy Funktion für Dateinen
        // bitte namen der Funktion so beibehalten

        public void LoadData() 
        {
          string filePath = "C:\\SemesterProjekt\\peopleList.dat";
            
           using (FileStream fs = new FileStream(filePath, FileMode.Open))
           {
               IFormatter formatter = new BinaryFormatter();
                people = (List<Person>)formatter.Deserialize(fs);
           }
           

            // Ramon 
        }

        public void SaveData()
        {
            string filePath = "C:\\SemesterProjekt\\peopleList.dat";

            using (FileStream fs = new FileStream(filePath, FileMode.Create)) // FileMode.Create, um eine neue Datei zu erstellen oder eine vorhandene Datei zu überschreiben
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, people); // Die Liste in die Datei serialisieren
            }
        }


    }


}
