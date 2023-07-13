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
        // description: Creating parameter for controller.
        private Model model;
        private Model.Person updatePerson;

        public Controller()
        {
            model = new Model();
            updatePerson = null;
        }

        public bool UpdatePerson()
        {

        }
    }
}
