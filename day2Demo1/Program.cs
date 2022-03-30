using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num9 = 29, i=0;
            // num9++;
            //++num9;
            i = 10 + ++num9;
            //i = 10 + num9++;

            Console.WriteLine("the i is {0}",i);
            Console.ReadKey();
        }
    }
}
