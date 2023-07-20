using ContactManager_ZBW.MMI.Function;
using ContactManager_ZBW.Model_Renato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactManager_ZBW.Milos.Controller
{
    public class Controller
    {
        private Function Function;
        private Person person;
        private int currentHeadcount = 0;
        public Person GetPerson(int index)
        {

        }

        public string GetPersonData(int index)
        {

        }

        public string[] GettAllPersonData()
        {

        }

        public int CreateNewPerson(Person temporaryPerson)
        {
            int headcount = Function.ChangeHeadcount();
            return (headcount - 1);
        }

        public void UpdatePerson(int index, Person person)
        {

        }
    }

}
