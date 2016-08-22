using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Problem1
    {
        IEnumerable<int> multiplesToCheck;

        /// <summary>
        /// Standard 3 and 5 will be the multiples that are checked for
        /// </summary>
        public Problem1() : this(3,5)
        {

        }
        

        public Problem1(params int[] multiplesToCheck)
        {
            this.multiplesToCheck = new List<int>(multiplesToCheck);
        }
        public long FindSum(int upperBounds)
        {
            long sum = 0;
            IEnumerable<long> multiples = FindMultiples(upperBounds);
            foreach (long multiple in multiples)
            {
                sum += multiple;
            }

            return sum;
        }

        private IEnumerable<long> FindMultiples(int upperBounds)
        {
            List<long> multiples = new List<long>();
            for (int i = 0; i < upperBounds; i++)
            {
                foreach (int multipleToCheck in multiplesToCheck)
                {
                    if (i % multipleToCheck == 0)
                    {
                        multiples.Add(i);
                        //breaks out of multiples to check loop, this prevents duplicate multiples to be added
                        break;

                    }
                }
            }
            return multiples;
        }
    }
}
