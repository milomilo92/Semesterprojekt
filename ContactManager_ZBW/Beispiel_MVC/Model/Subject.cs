using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_A12_1_6.Model
{
    class Subject
    {
        private Exam[] exams;

        private int examsCounter;

        public string Name { get; set; }

        public Subject (string name, int numberOfExams)
        {
            Name = name;
            exams = new Exam[numberOfExams];
            examsCounter = 0;
        }

        public bool AddExam (Exam exam)
        {
            if (examsCounter < exams.Length && exam != null)
            {
                exams[examsCounter++] = exam;
                return true;
            }
            return false;
        }

        public bool Equals (Subject other)
        {
            if (
                Name == other.Name
                &&  this.GetNumberOfExams() == other.GetNumberOfExams()
                )
            {
                return true;
            }
            return false;
        }

        public int GetNumberOfExams()
        {
            return exams.Length;
        }

        public double[] GetAllGrades()
        {
            List<double> grades = new List<double>();
                      
            foreach(Exam exam in exams)
            {
                if (exam != null)
                {
                    grades.Add(exam.Grade);
                }
            }
            
            return grades.ToArray();
        }

        public Exam GetBestExam()
        {
            Exam bestExam = null;

            foreach (Exam exam in exams)
            {
                if (bestExam == null || bestExam.Grade < exam.Grade)
                {
                    bestExam = exam;
                }
            }
            return bestExam;
        }

        public Exam GetExam(int number)
        {
            return exams[number];
        }
 
        public double GetGradePointAverage()
        {
            double sum = 0;
            double avg = 0;

            foreach (var exam in exams)
            {
                if (exam != null)
                sum += exam.Grade;
            }

            avg = sum / GetNumberOfExams();
            return avg;
        }

        public int GetNumberOfCompletedExams()
        {
            int sum = 0;
            foreach (var exam in exams)
            {
                if (exam.Grade > 4.0)
                {
                    sum ++;
                }
            }
            return sum;
        }

        public Exam GetWorstExam()
        {
            Exam worst = null;

            foreach (var exam in exams)
            {
                if (worst ==null || exam.Grade < worst.Grade)
                {
                    worst = exam;
                }
            }
            return worst;

        }

    }
}
