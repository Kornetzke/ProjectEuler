using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void FindLargetPrimeFactorOfZero()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(0);
            Assert.Fail("Arithmetic Exception not thrown");
        }

        [TestMethod]

        public void FindLargestPrimeFactorOfOne()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(1);
            long expected = 1;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FindLargestPrimeFactorOfTwo()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(2);
            long expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargestPrimeFactorOfThree()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(3);
            long expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargestPrimeFactorOfFour()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(4);
            long expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargestPrimeFactorOfFive()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(5);
            long expected = 5;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargestPrimeFactorOfSix()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(6);
            long expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLargestPrimeFactorOf12()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(12);
            long expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLargestPrimeFactorOf346896()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(346896);
            long expected = 73;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLargestPrimeFactorOf600851475143()
        {
            long actual = Problem3.FindLargestPrimeFactorOf(600851475143);
            long expected = 6857;

            Assert.AreEqual(expected, actual);
        }
    }
}
