using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Largest prime factor
    /// Problem 3
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public static class Problem3
    {
        public static long FindLargestPrimeFactorOf(long value)
        {
            if (value == 0)
                throw new ArithmeticException("Zero contains no prime factors");
            long largestPrimeFactor = 0;

            if (IsPrime(value))
                largestPrimeFactor = value;
            else
            {

                long[] primeFactors = GetPrimeFactorsOf(value);

                if (primeFactors.Length != 0)
                {
                    foreach (int i in primeFactors)
                    {
                        if (i > largestPrimeFactor)
                        {
                            largestPrimeFactor = i;
                        }
                    }
                }
            }
            

            return largestPrimeFactor;
        }

        private static long[] GetPrimeFactorsOf(long value)
        {
            HashSet<long> primeFactors = new HashSet<long>();

            for(long i =2; i <= value; i++)
            {
                
                bool divisable = value % i == 0;
                if (divisable)
                {
                    if (IsPrime(i))
                    {
                        primeFactors.Add(i);

                        value = value / i;
                        if (IsPrime(value))
                        {
                            primeFactors.Add(value);
                            break;
                        }
                        
                        i--;
                    }else
                    {
                        throw new Exception("Woah");
                    }
                }
            }

            return primeFactors.ToArray<long>();

        }

        private static bool IsPrime(long value)
        {
            bool prime = true;
            for(long i =2; i < value; i++)
            {
                if (value % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }
    }
}
