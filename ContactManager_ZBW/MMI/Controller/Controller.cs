﻿using ContactManager_ZBW.Model_Renato;
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


        public Person GetPerson(int index, ArrayList personList)

        {   int index = 

            for (int i = 0; i < personList.Count ; i++)
            {
                if (personList. == index)
                {

                   
                }

                return personList. ;
            }


        }

        public string[] GetAllPersonData()
        {

        }

        public static int CreateNewPerson(Person temporaryPerson, ArrayList personList)
        {
            int personId = Class1.SearchPersonId(temporaryPerson, personList);

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

        public void UpdatePerson(int index, Person temporaryPerson, ArrayList personList)
        {
            int personId = Class1.SearchPersonId(temporaryPerson, personList);

            if (index == personId)
            {
                Person.Update(temporaryPerson);
            }
        }


    }

}
