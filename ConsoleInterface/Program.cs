using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Problems;
using System.IO;
using System.Threading;

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
                ulong number;
                try
                {
                    number = UInt64.Parse(inputString);
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                ulong[] factors = Problem3.GetPrimeFactorsOf(number);
                
                if(factors.Length > 0)
                {
                    Console.WriteLine("Prime factors for : " + number);
                    ulong largest = 0;
                    foreach(ulong i in factors)
                    {
                        Console.Write(i + " ");
                        if (i > largest)
                            largest = i;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Largets prime factor is " + largest);
                }else
                {
                    Console.WriteLine("No prime factors found");
                }


            } while (running);
        }
    }
}
