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
        public static ulong FindLargestPrimeFactorOf(ulong value)
        {
            if (value == 0)
                throw new ArithmeticException("Zero contains no prime factors");
            ulong largestPrimeFactor = 0;

            if (IsPrime(value))
                largestPrimeFactor = value;
            else
            {

                ulong[] primeFactors = GetPrimeFactorsOf(value);

                if (primeFactors.Length != 0)
                {
                    foreach (ulong i in primeFactors)
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

        public static ulong[] GetPrimeFactorsOf(ulong value)
        {
            HashSet<ulong> primeFactors = new HashSet<ulong>();

            for(ulong i =2; i <= value; i++)
            {
                
                bool divisable = value % i == 0;
                if (divisable)
                {
                    if (primeFactors.Contains(i) || IsPrime(i))
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
                        throw new Exception(String.Format("Woah we missed some possible division earlier on, value:{0} i:{1} divisable:{2}",value,i,divisable));
                    }
                }
            }

            return primeFactors.ToArray();

        }
        /// <summary>
        /// Returns True if value is found to be prime, False if value is not found to be prime
        /// <para></para>
        /// A prime number is a whole number greater than 1, whose only two whole-number factors are 1 and itself.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if value is found to be prime, False if value is not found to be prime</returns>
        public static bool IsPrime(ulong value)
        {
            bool prime = true;
            if (value > 1)
            {
                //start maximumDenominator at value-1 to cover the case of value = 2 => should return true
                ulong maximumDenominator = value -1;
                for (ulong denominator = 2; denominator <= maximumDenominator; denominator++)
                {
                    if (value % denominator == 0)
                    {
                        prime = false;
                        break;
                    }
                    //divide value by the denominator to find the new value for what the maximum denominator can be
                    //add 1 to the new value to cover the possibility of remainders being dropped during division
                    maximumDenominator = (value / denominator) + 1;

                }
            }else 
            {
                // value is less than 1, prime set to false
                prime = false;
            }

            return prime;
        }
    }
}
