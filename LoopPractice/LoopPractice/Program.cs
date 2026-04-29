using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print even numbers from 1 to 20....
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    Console.WriteLine(i);
            //}

            //Print numbers using while....
            //int i= 0;

            //while(i < 5)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            //Sum of numbers from 1 to 10....
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //        sum += i;

            //}
            //Console.WriteLine(sum);

            //Multiplication table....
            //int num = 5;
            //for (int i = 1; i <= 10;i ++)
            //{

            //    Console.WriteLine(num + " x " + i + " = " + (num * i));
            //}

            //Reverse counting...
            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //find max in arrays...
            //int[] numbers = { 3, 7, 2, 9, 5 };
            //int max = numbers[0];
            //foreach (int i in numbers)
            //{
            //    if (i > max)
            //    {
            //        max = i;
            //    }
            //}
            //Console.WriteLine(max);

            //Print all values...
            //int[]numbers = {10, 20, 30, 40};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Keep asking user to enter a number until they enter 0...
            //string num = "";
            //while (num != "0")
            //{
            //    Console.WriteLine("Enter a number.");
            //     num =Console.ReadLine();
            //}

            //Ask user for password until it is "admin123"...
            //string PassWord = "";

            //while(PassWord != "admin123")
            //{
            //    Console.WriteLine("Enter password.");
            //    PassWord = Console.ReadLine();
            //}

            //Count how many times user enters numbers until they type -1...
            //int count = 0;
            //int num = 0;
            //while (num != -1)
            //{
            //    Console.WriteLine("Enter numbers. Enter -1 to stop.");
            //    num = Convert.ToInt32(Console.ReadLine());

            //    if (num != -1)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine($"Total Enter is: {count} ");

            //Cleaner Version...
            /* int sum = 0;
             while(true)
             {
                 Console.WriteLine("Enter numbers. Enter -1 to stop.");
                 int number = Convert.ToInt32(Console.ReadLine());
                 if (number == -1)
                     break;

                 sum += number;

             }
             Console.WriteLine($"Total Enter is: {sum} ");*/

            //Guessing game...(without random)
            string SecretNum = "";
            while (SecretNum != "0")
            {
                Console.WriteLine("Enter guessing number");
                SecretNum = Console.ReadLine();

            }

            //Count how many even numbers... 
            /*int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int count = 0;
            foreach(int i in numbers) 
            {
                if (i % 2 == 0)

                { count++; }

            }
            Console.WriteLine(count);*/

            //Count characters...
            //string text = "World";
            //int count = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    count++;
            //        }
            //Console.WriteLine(count);

            //Count vowels...
            //string text = "Education";
            //int count = 0;
            //foreach(var c in text.ToLower())
            //{
            //    if (c == 'a' || c == 'e' || c == 'i' || c == 'o'|| c=='u')
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);



        }
    }
}
