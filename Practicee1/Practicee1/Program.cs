using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee1
{
    internal class Program
    {
        static void Main(string[] args)
        {//====methods====
            //Add
            //even
            //find max
            //toUppercase
            List<int> numbers = new List<int> { 2, 5, 6, 8, 4, 7};

            Console.WriteLine($"Total: { Addnumber(5, 3)}");
            Console.WriteLine(GetEven(5));
            Console.WriteLine($"max: {FindMax(numbers)}");
            Console.WriteLine($"Min: {FindMin(numbers)}");
            Console.WriteLine(ToUpperCase("numbers"));
            Console.WriteLine(GetFullNmae("Shuchita", "Shawrin"));


        }
        static int Addnumber(int a, int b)
        {
            return a + b;
        }
        static bool GetEven(int a)
        { return a % 2 == 0; }

        static int FindMax(List<int>numbers)
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (i > max)
                { max = i; }
            }
            return max;
        }
        static int FindMin(List<int> numbers)
        {
            int min = numbers[0];
            foreach (int i in numbers)
            {
                if (i < min)
                { min = i; }
            }
            return min;
            
        }
        static string ToUpperCase(string text)
        {  return text.ToUpper(); }

        static string GetFullNmae(string fname, string lname)
        {
            return fname + " "+ lname;
        }
       
    }
}
