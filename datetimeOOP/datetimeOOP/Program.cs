using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetimeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //  DateTime now = DateTime.Now;
            /* Console.WriteLine(now);
             Console.WriteLine(now.Year);
             Console.WriteLine(now.Month);
             Console.WriteLine(now.Day);
             Console.WriteLine(now.Hour);
             Console.WriteLine(now.Minute);*/
            //DateTime birthday = new DateTime(1986, 12, 17);
            // Console.WriteLine(birthday);
            // DateTime utcnow = DateTime.UtcNow;
            //Console.WriteLine(utcnow);
           /* Console.WriteLine(now.ToString("dd/MM"));
            Console.WriteLine(now.ToString("dddd"));*/
           DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);
            // Console.WriteLine(tomorrow);
            /* DateTime nextYear = today.AddYears(1);
             Console.WriteLine(nextYear);
             DateTime nextMonth = today.AddMonths(1);
             Console.WriteLine(nextMonth);
             DateTime start = new DateTime(2026, 1, 1);
             DateTime end = DateTime.Now;
             TimeSpan difference = end - start;
             Console.WriteLine(difference);*/
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2025, 12, 31);

            if (d1 < d2)
            {
                Console.WriteLine("Future date");
            } else
            {
                Console.WriteLine("past");
            }
        }
    }
}
