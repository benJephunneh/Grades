using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        //## GradeBook class
        //***
        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }

        //#### ComputeStats
        public override GradeStats ComputeStats()//---
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
        public override void AddGrade(float grade)//---
        {
            grades.Add(grade);
        }

        //#### WriteGrades
        public override void WriteGrades(TextWriter destination)//---
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
        }

        //---
        protected List<float> grades;
    }
}
