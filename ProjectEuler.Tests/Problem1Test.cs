using System;
using ProjectEuler.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace ProjectEuler.Tests
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    [TestClass]
    public class Problem1Test
    {

        Problem1 p1;

        [TestInitialize]
        public void TestInit()
        {
            p1 = new Problem1();
        }

        [TestMethod]
        public void SampleProblemTest()
        {
            long expected = 23L;
            long actual = p1.FindSum(10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpperBoundsZeroTest()
        {
            long expected = 0;
            long actual = p1.FindSum(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Upperbounds12Test()
        {
            // natural number below 12 that are multiples of 3 or 5 summed together
            long expected = 3 + 5 + 6 + 9 + 10; // 12 is not included, below does not include
            long actual = p1.FindSum(12);

            Assert.AreEqual(expected, actual);
        }

        //This test will stress numbers that are multiples of both 3 and 5, 15 shouldn't appear twice
        [TestMethod]
        public void UpperBounds16Test()
        {
            long expected = 3 + 5 + 6 + 9 + 10 + 12 + 15;
            long actual = p1.FindSum(16);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpperBounds1000Test()
        {
            long expected = 233168; //found from projecteuler.net problem1 solution
            long actual = p1.FindSum(1000);

            Assert.AreEqual(expected, actual);
        }
    }
}
