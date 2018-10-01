using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_lab3
{
    class Program
    {
       
        static void Main(string[] args)
        {
           // Create a simple for loop that displays the values of the counter
           // The Writeline method here demonstrates the use of styring interpolation in c#
           // as a way of outputting literal string values with variable values.
           // It is the recommended way to deal  with this method of string output
           for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Counter is at: {counter}");
            }

            // This sample uses a nested loop to find prime numbers
            // less than 100

            int outer;
            int inner;

            for (outer = 2; outer <100; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                {
                    if ((outer % inner) == 0) break; // if factor found not prime
                }
                if (inner > (outer / inner))
                {
                    Console.WriteLine("{0} is prime", outer);
                }
            }

           
        }
    }
}
