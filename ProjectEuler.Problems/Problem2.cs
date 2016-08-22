using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem2
    {
        public int FindSum(int sizeOfSequence)
        {
            int sum = 0;
            int[] sequence = GetFibonacciSequence(sizeOfSequence);
            foreach(int i in sequence)
            {
                if(i %2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public int[] GetFibonacciSequence(int size, Nullable<int> valueLimit = null)
        {
            List<int> sequence = new List<int>();

            int n = 0;
            int nMinus1 = 1;
            int nMinus2 = 0;

            for(int i =1; i <= size; i++)
            {
                //find next sequence, n = n-1 + n-2
                n = nMinus1 + nMinus2;

                if(valueLimit.HasValue && n > valueLimit.Value)
                {
                    break;
                }

                //set new values for n-1 and n-2
                // "move" the values up on level
                nMinus2 = nMinus1;
                nMinus1 = n;

                //add the new value to the sequence
                sequence.Add(n);
            }

            return sequence.ToArray();
        }
    }
}
