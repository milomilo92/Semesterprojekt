using ContactManager_ZBW.Model_Renato;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ContactManager_ZBW.Ramon
{
    public class Class1
    {

        public string GetStringsFromFile(string filepath)
        {
            string stringLine;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filepath);
                //Read the first line of text
                stringLine = sr.ReadLine();
                //Continue to read until you reach end of file
                while (stringLine != null) ;
                {
                    //write the line to console window
                    Console.WriteLine(stringLine);
                    //Read the next line
                    stringLine = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
                return stringLine;
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
                return null;

            }
            finally
            {
                MessageBox.Show("Executing finally block.");

            }

        }

        public string WriteStringsIntoFile(string filepath, string text)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(filepath);
                //Write a line of text
                sw.WriteLine(text);
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();

                return "writeComnplete";
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }


        public static List<int> SearchAllMatchingPersons(Person person, List<Person> personList)
        {
            List<int> resultList = new List<int>();
            int i = 0;
            foreach (Person checkedPerson in personList)
            {
                if (personList[i].Equals(person))
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
