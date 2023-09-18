using System;

namespace ContactManager_ZBW.Model
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
