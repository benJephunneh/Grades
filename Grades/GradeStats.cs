namespace Grades
{
    public class GradeStats
    {
        //## Calculate grade statistics
        //***
        public float SumOfGrades;
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStats()
        {
            SumOfGrades = 0;
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        //#### Return the letter grade for the average
        public string LetterGrade//---
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        //#### Return grade description for the letter
        public string Description//---
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent.  ";
                        break;
                    case "B":
                        result = "Very nice.  ";
                        break;
                    case "C":
                        result = "Not too bad, not too good.  ";
                        break;
                    case "D":
                        result = "Needs improvement.  ";
                        break;
                    case "F":
                        result = "Very poor.  ";
                        break;
                    default:
                        result = "No letter grade available.  ";
                        break;
                }
                return result;
            }
        }
    }
}
