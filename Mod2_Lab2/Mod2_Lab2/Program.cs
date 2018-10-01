using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a switch block

            int cost = 0;
            do
            {

                Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
                Console.Write("Please enter your selection: ");
                string str = Console.ReadLine();
                

                switch (str)
                {
                    case "1":
                    case "small":
                        cost += 25;
                        break;
                    case "2":
                    case "medium":
                        cost += 50;
                        break;
                    case "3":
                    case "large":
                        cost += 75;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please select 1,  2, or 3.");
                        break;
                }

            } while (cost == 0);

            

            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");
        }
    }
}
