using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(10);
            book.AddGrade(90);

            GradeStats results = book.ComputeStats();

            Assert.AreEqual(90, results.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(10);
            book.AddGrade(90);

            GradeStats results = book.ComputeStats();

            Assert.AreEqual(10, results.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStats results = book.ComputeStats();

            Assert.AreEqual(85.17f, results.AverageGrade, .01);
        }
    }
}
