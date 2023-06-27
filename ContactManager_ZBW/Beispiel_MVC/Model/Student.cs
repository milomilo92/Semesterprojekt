using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Aufgabe_A12_1_6.Model
{
    class Student
    {
        private int subjectCounter;
        private Subject[] subjects = new Subject[0];

        public DateTime Birthday { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Student (string firstname, string lastname, DateTime birthday)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
        }

        public Student() : this("Hans", "Muster", new DateTime(2000,1,1)) { }

        public bool Equals (Student other)
        {
            if (other != null && 
                other.Firstname == Firstname &&
                other.Lastname == Lastname){
                return true;
            }
            return false;
        }

        public bool AddSubject (Subject subject)
        {
            if (subject != null)
            {
                Subject[] temporarySubjects = new Subject[subjects.Length + 1];
                subjects.CopyTo(temporarySubjects, 0);
                temporarySubjects[temporarySubjects.Length - 1] = subject;
                subjects = temporarySubjects;
                subjectCounter++;
                return true;
            }
            return false;
        }

        public string[] GetAllSubjectNames()
        {
            string[] names = new string[subjects.Length];
            int counter = 0;

            foreach (Subject subject in subjects)
            {
                names[counter] = subject.Name;
                counter++;
            }
            return names;
        }

        public string GetData()
        {
            return $"{Firstname} {Lastname} {Convert.ToString(Birthday)}";
        }

        public double GetGradePointAverageOfAllSubjects()
        {
            if (subjects.Length > 0)
            {
                double avg = 0;
                foreach (Subject subject in subjects)
                {
                    avg += subject.GetGradePointAverage();
                }
                return avg / subjects.Length;
            }
            return 0;
        }

        public Subject GetSubject(string name)
        {
            foreach(Subject subject in subjects)
            {
                if (subject.Name == name) return subject;
            }
            return null;
        }

    }
}
