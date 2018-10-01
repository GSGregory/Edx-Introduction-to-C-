using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_test_looping_code
{
    class Program
    {
        static void Main(string[] args)
        {
      

            for (int counterLine = 0; counterLine < 8; counterLine++)
            {
                if (counterLine == 0)
                {
                    Console.WriteLine("XOXOXOXO");

                }
                else if (counterLine % 2 == 0)
                {
                    Console.WriteLine("XOXOXOXO");
                }

                else
                {
                    Console.WriteLine("OXOXOXOX");

                }
            }

        }
    }
}
