using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Problems;

namespace ConsoleInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputString;
            bool running = true;
            do
            {
                Console.WriteLine("Input number to find prime factors");
                inputString = Console.ReadLine();
                long number;
                try
                {
                    number = Int64.Parse(inputString);
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                long[] factors = Problem3.GetPrimeFactorsOf(number);
                long largest = factors.Max();
                StringBuilder sb = new StringBuilder(String.Format("Prime Factors for Number : {0}", number));
                sb.AppendLine();
                foreach(long i in factors)
                {
                    sb.Append(i + " ");
                }
                sb.AppendLine();
                sb.AppendLine("Largest prime is " + largest);
                Console.WriteLine(sb.ToString());

            } while (running);
        }

    }
}
