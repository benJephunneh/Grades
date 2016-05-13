using System.Collections;
using System.IO;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
        void AddGrade(float grade);
        GradeStats ComputeStats();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
    }
}