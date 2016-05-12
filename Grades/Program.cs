using System;

namespace Grades
{
    class Program
    {
        //# Main program
        //***
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.WriteGrades(Console.Out);

            GradeStats stats = book.ComputeStats();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        //#### Write results to console
        static void WriteResult(string description, string result)//---
        {
            Console.WriteLine($"{description} Grade: {result}");
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description} Grade: {result:F2}");
        }
    }
}
