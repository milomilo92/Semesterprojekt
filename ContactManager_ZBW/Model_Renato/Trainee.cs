using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager_ZBW.Model_Renato
{
    // Class Trainee
    // description: This is the class Trainee
    [Serializable]
    public class Trainee : Employee
    {
        public int TraineeYears { get; set; }
        public int ActualTraineeYear { get; set; }
    }
}
