using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void FindLargetPrimeFactorOfZero()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(0);
            Assert.Fail("Arithmetic Exception not thrown");
        }
        
        [TestMethod]
        public void FindLargestPrimeFactorOfTwo()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(2);
            ulong expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargestPrimeFactorOfThree()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(3);
            ulong expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargestPrimeFactorOfFour()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(4);
            ulong expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargestPrimeFactorOfFive()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(5);
            ulong expected = 5;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargestPrimeFactorOfSix()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(6);
            ulong expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLargestPrimeFactorOf12()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(12);
            ulong expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLargestPrimeFactorOf346896()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(346896);
            ulong expected = 73;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLargestPrimeFactorOf600851475143()
        {
            ulong actual = Problem3.FindLargestPrimeFactorOf(600851475143);
            ulong expected = 6857;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsPrimeTest()
        {
            //prime number list from internet
            ulong[] primeNumbers = new ulong[]{
                2,3,5,7,11,13,17,19,23,
                29,31,37,41,43,47,53,59,61,67,
                71,73,79,83,89,97,101,103,107,109,
                113,127,131,137,139,149,151,157,163,167,
                173,179,181,191,193,197,199,211,223,227,
                229,233,239,241,251,257,263,269,271,277,
                281,283,293,307,311,313,317,331,337,347,
                349,353,359,367,373,379,383,389,397,401,
                409,419,421,431,433,439,443,449,457,461,
                463,467,479,487,491,499,503,509,521,523,
                541,547,557,563,569,571,577,587,593,599,
                601,607,613,617,619,631,641,643,647,653,
                659,661,673,677,683,691,701,709,719,727,
                733,739,743,751,757,761,769,773,787,797,
                809,811,821,823,827,829,839,853,857,859,
                863,877,881,883,887,907,911,919,929,937,
                941,947,953,967,971,977,983,991,997,
            };
            StringBuilder sb = new StringBuilder();
            for (ulong i = 1; i <= 1000; i++)
            {
                bool actual = Problem3.IsPrime(i);
                bool expected = primeNumbers.Contains(i);
                if (actual != expected)
                {
                    sb.AppendLine(String.Format("Actual {0} does not match expected {1}, value of {2}", actual, expected, i));
                }
            }

            Assert.IsTrue(sb.Length == 0, sb.ToString());
        }
    }
}
