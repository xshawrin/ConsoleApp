using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemiArrays_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<string> names = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("Enter different names.");
            //    string name = Console.ReadLine();
            //    names.Add(name);

            //    if (name == string.Empty)
            //        break;

            //    if (names.Count == 1)
            //    {
            //        Console.WriteLine($"Only one person likes your post: {names}");
            //    }
            //    else if (names.Count == 2)
            //    {
            //        Console.WriteLine("Two people like your post.");
            //    }
            //    else if (names.Count == 3)
            //    {
            //        Console.WriteLine("Three people like your post");
            //    }

            //}
            /* while (true)
             {
                 Console.WriteLine("Enter a name (or press Enter to finish):");
                 string name = Console.ReadLine();

                 if (string.IsNullOrEmpty(name))
                     break;

                 names.Add(name);
             }

             if (names.Count == 0)
             {
                 Console.WriteLine("No one likes your post.");
             }
             else if (names.Count == 1)
             {
                 Console.WriteLine($"{names[0]} likes your post.");
             }
             else if (names.Count == 2)
             {
                 Console.WriteLine($"{names[0]} and {names[1]} like your post.");
             }
             else if (names.Count == 3)
             {
                 Console.WriteLine($"{names[0]}, {names[1]} and {names[2]} like your post.");
             }
             else
             {
                 Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
             }*/

            /*Write a program and ask the user to enter their name.
            Use an array to reverse the name and then store the result
            in a new string. Display the reversed name on the console...*/

            /*string [] names = new string[3];
        
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name: ");
                names[i] = Console.ReadLine();
            }
            Array.Reverse(names);
            foreach (string name in names)
                Console.WriteLine(name);

            string [] store = new string[3];
            Array.Copy(names, store, store.Length);
            Console.WriteLine("copy:");
            Array.Reverse(store);
            foreach (string name in store)
                Console.WriteLine(name);*/

            /*Write a program and ask the user to enter 5 numbers.
            If a number has been previously entered, display an error
            message and ask the user to re-try. Once the user successfully
            enters 5 unique numbers, sort them and display the result on the
            console...*/
            /*  int[] numbers = new int[5];
              int Count = 0;

              while (Count < 5)
              {
                  Console.WriteLine("Enter nambers: ");
                  int number = Convert.ToInt32(Console.ReadLine());


                  bool isDuplicate = false;
                  for (int i = 0; i < Count; i++)
                  {

                      if (numbers[i] == number)
                      {

                          isDuplicate = true;
                          break;
                      }
                  }
                  if (isDuplicate)
                  {
                      Console.WriteLine("Number already entered. Try again.");
                  }
                  else
                  {
                      numbers[Count] = number;
                      Count++;
                  }

              }
              Array.Sort(numbers);

                  Console.WriteLine($"Sort numbers:");
              foreach (int i in numbers)
                  Console.WriteLine(i);*/

            // Ask the user to enter 5 numbers and display the largest number...

            /* int[] numbers = new int[5];
             int count = 0;
             int Highest = numbers[0];

             while (count < 5)// use for how many times can input
             {
                 Console.WriteLine("Enter numbers");
                 numbers[count] = Convert.ToInt32(Console.ReadLine());

                 for (int i = 0; i < numbers.Length; i++)//to check data 1 by 1
                 {
                     if (numbers[i] > Highest)
                     {
                         Highest = numbers[i];
                     }
                 }
                 count++;

             }
             Console.WriteLine(Highest);*/

            //Ask the user to enter 5 numbers. Display the total sum...
           /* int[] numbers = new int[5];
            int count = 0;
            int sum = 0;
            while (count < 5)
            {
                Console.WriteLine("Enter numbers");
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }

                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
 
            Console.WriteLine(sum);*/


            //Ask for 5 numbers.Display how many are positive...//Negative < 0
           /* int[] numbers = new int[5];
            int count = 0;
            int positiveNum =0 ;
           
            while (count < 5)
            {
                Console.WriteLine("Enter numbers");
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    positiveNum++;
                   
            }
            Console.WriteLine(positiveNum);*/

           // Find average
           /* int[] numbers = new int[5];
            int count = 0;
           
            int sum = 0;

            while (count < 5)
            {
                Console.WriteLine("Enter numbers");
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double sumAverage = sum / 5.0;
            Console.WriteLine(sumAverage);*/

            // Display Numbers Greater Than 10...
           /* int[] numbers = new int[5];
            int count = 0;

            while (count < 5)
            {
                Console.WriteLine("Enter numbers");
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                    Console.WriteLine(numbers[i]);
            }*/

            //Find Second Largest Number...
            int[] numbers = { 19, 16, 20, 3, 18 };
            int largest = int.MinValue;
            int SecondLargest = int.MinValue;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    SecondLargest = largest;
                    largest = numbers[i]; 
                }

                else if (numbers[i] > SecondLargest && numbers[i] != largest)
                {
                    SecondLargest = numbers[i];
                }
            }
            
            Console.WriteLine(SecondLargest);







        }
    }
}
