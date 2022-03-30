using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Demo5
{
    enum Mydate
    {
        Sun = 0,
        Mon = 1,
        Tue = 2,
        Wen = 3,
        Thu = 4,
        Fri = 5,
        Sat = 6
    }

    class Program
    {
      


        static void Main(string[] args)
        {
            int k = (int)DateTime.Now.DayOfWeek; //
            switch (k)
            {
                case (int)Mydate.Sun: Console.WriteLine("Today is Sunday"); break;
                case (int)Mydate.Mon: Console.WriteLine("Today is Monday"); break;
                case (int)Mydate.Tue: Console.WriteLine("Today is Tuesday"); break;
                case (int)Mydate.Wen: Console.WriteLine("Today is Wendesday"); break;
                case (int)Mydate.Thu: Console.WriteLine("Today is Thursday"); break;
                case (int)Mydate.Fri: Console.WriteLine("Today is Friday"); break;
                case (int)Mydate.Sat: Console.WriteLine("Today is Saturday"); break;


            }

            Console.ReadLine();
        }
    }
}
