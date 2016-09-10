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

        public static long[] GetPrimeFactorsOf(long value)
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
                        throw new Exception(String.Format("Woah, value:{0} i:{1} divisable:{2}",value,i,divisable));
                    }
                }
            }

            return primeFactors.ToArray<long>();

        }
        /// <summary>
        /// A prime number is a whole number greater than 1, whose only two whole-number factors are 1 and itself.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPrime(long value)
        {
            bool prime = true;
            if (value > 1)
            {
                long maxCheck = value - 1;
                for (long i = 2; i <= maxCheck; i++)
                {
                    if (value % i == 0)
                    {
                        prime = false;
                        break;
                    }

                    maxCheck = (value + (value % i)) / i;
                }
            }else
            {
                prime = false;
            }

            return prime;
        }
    }
}
