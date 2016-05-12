using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook
    {
        //## GradeBook class
        //***
        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }

        //#### ComputeStats
        public GradeStats ComputeStats()//---
        {
            Console.WriteLine("GradeBook::ComputeStats");
            GradeStats stats = new GradeStats();

            foreach (float grade in grades)
            {
                stats.SumOfGrades += grade;
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
            }

            stats.AverageGrade = stats.SumOfGrades / grades.Count;
            return stats;
        }

        //#### AddGrade
        public void AddGrade(float grade)//---
        {
            grades.Add(grade);
        }

        //#### WriteGrades
        public void WriteGrades(TextWriter destination)//---
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cain't be null or empty.");
                }

                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }
                _name = value;
            }
        }

        public event NameChangedDelegate NameChanged;
        private string _name;
        protected List<float> grades;
    }
}
