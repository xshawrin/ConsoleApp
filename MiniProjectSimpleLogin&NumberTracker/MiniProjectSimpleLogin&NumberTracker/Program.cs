using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectSimpleLogin_NumberTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string PassWord = "";
            int attempts = 0;
            while (PassWord != "admin123" && attempts < 3)
            {
                Console.WriteLine("Enter password.");
                PassWord = Console.ReadLine();
                attempts++;

                if (PassWord != "admin123" && attempts < 3)
                {
                    Console.WriteLine($"Wrong password! You have {attempts.}");
                }
            }
            Console.WriteLine("Access granted.");
            int sum = 0;
            int count = 0;
            while (true)
            {
                    Console.WriteLine("Enter numbers.Enter -1 to stop.");
                    int number = Convert.ToInt32(Console.ReadLine());
                    
                    if (number == -1)
                    
                        break;

                        count++;
                sum += number;
            }
            Console.WriteLine($" Total Enter is: {count}. Total sum is: {sum}.");
        }
    }
}
