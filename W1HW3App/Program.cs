using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class LeapYearFinder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} is a Leap year", year);
            }
            else
                Console.WriteLine("{0} is not a Leap year", year);
            Console.ReadKey();
        }
    }
}
