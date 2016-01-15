using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Homework.Day1.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TDD.Homework.Day1.Lib.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalNumberTest_CostCollection_By_Tree_Numbers_Summary_Equals_ExpectedCollection()
        {
            // arrange
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var expected = new int[] { 6, 15, 24, 21 };

            // act
            var actualX = Calculator.CalNumber(nums, 3);
            int[] actual = new int[actualX.Count];
            actualX.CopyTo(actual, 0);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CalNumberTest_RevenueCollection_By_four_Numbers_Summary_Equals_ExpectedCollection()
        {
            // arrange
            var nums = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            var expected = new int[] { 50, 66, 60 };

            // act
            var actualX = Calculator.CalNumber(nums, 4);
            int[] actual = new int[actualX.Count];
            actualX.CopyTo(actual, 0);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
