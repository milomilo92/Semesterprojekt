using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ContactManager_ZBW.Model_Renato
{
    // Class Employee
    // description: This is the class Employee
    [XmlInclude(typeof(Trainee))]
    [Serializable]
    public class Employee : Person
    {
        //public Guid EmployeeNumber { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Employment { get; set; }
        public string Role { get; set; }
        public int CadreLevel { get; set; }

        public static int Counter { get; set; }
        
        public int EmployeeNumber { get; set; }

        
        public Employee()
        {
            Counter++;
            EmployeeNumber = Counter;
        }

        
    }

}
