using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Aufgabe_A12_1_6.Model;

namespace Aufgabe_A12_1_6.Controller
{
    class ClassManager
    {

        private int studentsCounter;

        //Mit veralteter ArrayList:
        //private ArrayList students = new ArrayList();

        private List<Student> students = new List<Student>();

        public ClassManager() { }

        public bool AddStudent(Student student) {
            if (student != null)
            {
                students.Add(student);
                studentsCounter++;
                return true;
            }
            return false;
        }

        public string GetBestStudent()
        {
            string bestStudent = "";

            if (students.Count != 0)
            {
                double bestAverage = 0;
                foreach (Student student in students)
                {
                    if (student.GetGradePointAverageOfAllSubjects() > bestAverage)
                    {
                        bestAverage = student.GetGradePointAverageOfAllSubjects();
                        bestStudent = student.GetData();
                    }
                }
            }
            else bestStudent = "no Students in Class";
            return bestStudent;
        }

        public string GetDataOfStudent(int pos)
        {
            // Mit veralteter ArrayList:
            //string returnData = $"Student/in {((Student)students[pos]).GetData()} besucht die Fächer: \r\n\r\n";

            string returnData = $"Student/in {students[pos].GetData()} besucht die Fächer: \r\n\r\n";
            foreach (string subjectName in students[pos].GetAllSubjectNames())
            {
                Subject subject = students[pos].GetSubject(subjectName);
                returnData += $"{subject.Name} - Noten: ";
                foreach(double grade in subject.GetAllGrades())
                {
                    returnData += Convert.ToString(grade) + ", ";
                }
               
                returnData += "Schnitt: "+Convert.ToString(subject.GetGradePointAverage());
                returnData += "\r\n";
                
            }

            return returnData;
        }

        public string[] GetDataOfStudents()
        {
            List<string> returnData = new List<String>();
            foreach(Student student in students)
            {
                returnData.Add(student.GetData());
            }
            return returnData.ToArray();
        }

        //Code von Aufgabenstellung übernommen:
        #region TestCase only for Testing 

        public void GenerateTestClass() {

            // Creating Students 
            AddStudent(new Student("Hans", "Keller", new DateTime(1990, 1, 14))); 
            AddStudent(new Student("Petra", "Müller", new DateTime(1985, 5, 28))); 
            AddStudent(new Student("Conrad", "Flusch", new DateTime(1991, 4, 12))); 
            AddStudent(new Student("Nora", "Jones", new DateTime(1987, 12, 23))); 
            AddStudent(new Student("Dominik", "Ammann", new DateTime(1999, 7, 18))); 
            AddStudent(new Student("Petra", "Müller", new DateTime(1997, 8, 1))); 
            AddStudent(new Student("Silvan", "Emmisegger", new DateTime(1990, 1, 14)));

            string[,] subjectdata = { 
                { "Mathematik", "2" }, 
                { "Englisch", "3" }, 
                { "Deutsch", "2" }, 
                { "Marketing", "1" }, 
                { "Informatik", "3" }, 
                { "Physik", "2" }
            };

        Random r = new Random();

        for (int y = 0; y<studentsCounter; y++)
        {
            for (int c = 0; c <= subjectdata.GetUpperBound(0); c++)
                { 
                    // Assigning subjects to students 
                    students[y].AddSubject(new Subject(subjectdata[c, 0], Convert.ToInt16(subjectdata[c, 1]))); 
                }

                // Assigning exams for subjects to students 
                Exam math1 = new Exam(new DateTime(2018, 5, 12), 60);

                // Generating random value for grade of exam 
                math1.Grade = 3 + r.Next(0, 3); 

                // Adding exam to students 
                students[y].GetSubject("Mathematik").AddExam(math1);

                // Assigning exams for subjects to students 
                Exam math2 = new Exam(new DateTime(2018, 7, 24), 60);

                // Generating random value for grade of exam 
                math2.Grade = 3 + r.Next(0, 3); 

                // Adding exam to students 
                students[y].GetSubject("Mathematik").AddExam(math2);

                // Assigning exams for subjects to students 
                Exam inf1 = new Exam(new DateTime(2018, 8, 12), 75);

                // Generating random value for grade of exam 
                inf1.Grade = 3 + r.Next(0, 3); ;   

                // Adding exam to students 
                students[y].GetSubject("Informatik").AddExam(inf1); }
        } 
        #endregion
    }
}
