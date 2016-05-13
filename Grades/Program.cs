using System;
using System.IO;

namespace Grades
{
    class Program
    {
        //# Main program
        //***
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            //GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        //#### Write the results to console
        private static void WriteResults(IGradeTracker book)//---
        {
            GradeStats stats = book.ComputeStats();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        //#### Save the grades in grades.txt
        private static void SaveGrades(IGradeTracker book)//---
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        //#### Add the grades to the GradeBook
        private static void AddGrades(IGradeTracker book)//---
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        //#### Request book name from user
        private static void GetBookName(IGradeTracker book)//---
        {
            try
            {
                Console.WriteLine("Please enter a name: ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
