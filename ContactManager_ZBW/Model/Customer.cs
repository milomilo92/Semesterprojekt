using System;
using System.Collections.Generic;

namespace ContactManager_ZBW.Model
{



    // Class Customer
    // description: This is the class Customer
    [Serializable]
    public class Customer : Person
    {
        public string CompanyName { get; set; }
        public char CustomerType { get; set; }
        public string CompanyContact { get; set; }
        public string newLogEntry { get; set; }
        public string getAllLogEntries { get; set; }
        public string LogEntries { get; set; }

        public List<string> SLogEntries { get; set; }


        public Customer()
        {
            SLogEntries = new List<string>();

        }

        // Adds the LogEntry to Customer 
        public void AddLogEntry(String LogText)
        {
            DateTime actualDateTime = DateTime.Now;
            SLogEntries.Add(LogText + ": " + actualDateTime.ToString());
        }

        // Shows all LogEntrys for a Customer
        public string[] GetAllLogEntries()
        {
            return SLogEntries.ToArray();
        }
    }
}