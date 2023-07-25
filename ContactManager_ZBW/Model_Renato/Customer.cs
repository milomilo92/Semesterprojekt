using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager_ZBW.Model_Renato
{
    // Class Customer
    // description: This is the class Customer
    internal class Customer : Person
    {
        public string CompanyName { get; set; }
        public char CustomerType { get; set; }
        public string CompanyContact { get; set; }
        public string newLogEntry { get; set; }
        public string getAllLogEntries { get; set; }
        public string LogEntries { get; set; }

        // Function AddLogEntry
        Public string AddLogEntry(string newLogEntry)
        {

        }
    }
}
