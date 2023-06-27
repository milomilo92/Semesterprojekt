using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_A12_1_6.Model
{
    class Exam
    {
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public double Grade { get; set; }

        public Exam (DateTime date, int duration, double grade)
        {
            Date = date;
            Duration = duration;
            Grade = grade;
        }

        public Exam(DateTime date, int duration) : this(date, duration, 0) { }

        

        public bool Equals(Exam other)
        {
            if (
                    other.Date == Date
                &&  other.Duration == Duration
                &&  other.Grade == Grade
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
