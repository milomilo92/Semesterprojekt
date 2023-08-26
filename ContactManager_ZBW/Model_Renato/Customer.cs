using System;
using System.Collections.Generic;

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

        private List<string> SLogEntries { get; set; }


        public Customer()
        {
            SLogEntries = new List<string>();

        }


        public void AddLogEntry(String LogText)
        {
            DateTime actualDateTime = DateTime.Now;
            SLogEntries.Add(LogText + ": " + actualDateTime.ToString());
        }

        public string[] GetAllLogEntries()
        {
            return SLogEntries.ToArray();
        }
    }
}