using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
           // Console.WriteLine(dt);
            string strDateTime = String.Format("{0:D}", dt);
            Console.WriteLine(strDateTime);
            Console.ReadLine();

        }
    }
}
