using ContactManager_ZBW.Model;
using System.Collections.Generic;

namespace ContactManager_ZBW.SupportController
{
    public class Class1
    {

        // Function SearchAllMatchingPersons
        // description: Checks all the persons in 'personList', if they are matching the 'person'
        // Returns a list of the indexes of the matching persons.
        public static List<int> SearchAllMatchingPersons(Person person, List<Person> personList)
        {
            List<int> resultList = new List<int>();
            int i = 0;
            foreach (Person checkedPerson in personList)
            {
                if (person.Equals(checkedPerson))
                {
                    resultList.Add(i);
                }
                i++;
            }
            return resultList;
        }


        public static int SearchPersonId(Person person, List<Person> personList)

        {
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Equals(person))
                {
                    return i;

                }

            }
            return -1;

        }

        public Person SearchPersonObject(Person person, List<Person> personList)

        {
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Equals(person))
                {
                    return personList[i];

                }

            }
            return null;
        }
    }
}
