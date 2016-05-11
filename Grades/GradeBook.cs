using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }

        public GradeStats ComputeStats()//---
        {
            GradeStats stats = new GradeStats();

            foreach(float grade in grades)
            {
                stats.SumOfGrades += grade;
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
            }

            stats.AverageGrade = stats.SumOfGrades / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)//---
        {
            grades.Add(grade);
        }

//---
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }

        public event NameChangedDelegate NameChanged;
        private string _name;
        private List<float> grades;
    }
}
