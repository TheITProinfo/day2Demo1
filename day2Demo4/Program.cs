using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 329;
            //if (i>330)
            //{
            //    Console.WriteLine("i great than 330");
            //}
            //else
            //{
            //    Console.WriteLine("i less than 330");
            //}
            //Console.ReadKey();

            const int i = 18;
            const int j = 32;
            const int k = 60;
            int youAge = 0;
            Console.WriteLine("please enter your age:");
            youAge = Int32.Parse(Console.ReadLine());
            if (youAge <= i)
            {
                Console.WriteLine("your age is less than 18");
            }
            else if (youAge > i && youAge <= j)
            {
                Console.WriteLine("your age between 18 and 32");
            }
            else if (youAge > j && youAge <= k)
            {
                Console.WriteLine("your age betweeb 32 and 60");
            }
            else
            {
                Console.WriteLine("your age greater than 60");
            }


            Console.ReadKey();

        }
    }
}
