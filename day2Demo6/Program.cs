using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nthis is No. {0} loop\t",i+1);
                for (int j = 0; j < 200; j++)
                {
                    if (j == 20)
                        break;
                    Console.Write(j+"   ");

                }

            }
            Console.ReadLine();


        }
    }
}
