using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        private ArrayList sLogEntries;

     
        public Customer()
        {
            sLogEntries = new ArrayList();

        }


        public void AddLogEntry(DateTime LogDate, String LogText)
        {

            ArrayList LogEntryList = new ArrayList();
            LogEntryList.Add(LogText);
            LogEntryList.Add(LogDate);

            sLogEntries.Add(LogEntryList);

     
        }
    }
}