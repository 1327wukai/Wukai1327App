using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW2App
{
    internal class DayPrinter
    {
        static void Main(string[] args)
        {
            String[] days = { "Monday","Tuesday", "Wednesday", "Thursday", "Friday", "Staturday", "Sunday" };
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

        }
    }
}
