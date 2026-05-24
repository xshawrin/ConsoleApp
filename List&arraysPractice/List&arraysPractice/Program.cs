using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace List_arraysPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find the smallest...
            /*int[] numbers = new int[5];
            //int smalest = numbers[0];integer arrays are initialized with zeros. If we take the
            //value here, output will be 0.

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine("Enter numbers");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smalest = numbers[0];//right position
            foreach (int i in numbers)
                {
                    if (i < smalest)
                    {
                        smalest = i;
                    }
                }
            Console.WriteLine(smalest);*/

            //Find the largest...
            /*int[] numbers = new int[5];

            //int largest = numbers[0];//if all the values are negative the output will be 0.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter numbers.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = numbers[0];//safer place
            foreach (int i in numbers)
            {
                if(i > largest)
                {
                    largest = i;
                }
            }
            Console.WriteLine(largest);*/

            //Sum of Numbers...
            /* int[] numbers = new int[5];
             int sum = 0;

             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Enter numbers.");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());
                 sum += numbers[i];
             }
             Console.WriteLine(sum);*/

            //Count positive...
            /* int[] numbers = new int[5];
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Enter numbers.");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());

             }
             int count = 0;
             foreach (int i in numbers)
             {

                 if (i > 0)
                 {
                     count++;
                 }
             }
             Console.WriteLine(count);*/

            //Find Average...
            /* int[] numbers = new int[5];
             int sum = 0;
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Enter numbers.");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());
                 sum += numbers[i];
             }
             double average = (double)sum / numbers.Length;
             Console.WriteLine(average);*/

            //Display Numbers Greater Than 10...
            /*int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter numbers.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in numbers)
            {
                if (i > 10)
                    Console.WriteLine(i);
            }*/

            //Find second largest number...
            /* int[] numbers = new int[5];//int[] numbers = { 5, 8, 2, 10, 3 };
             for (int i=0; i<numbers.Length; i++)
             {
                 Console.WriteLine("Enter numbers.");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());
             }
             int largest = numbers[0];
             int secondLargest = numbers[0];
             int thirdLargest = numbers[0];
             foreach (int i in numbers)
             {
                 if (i > largest)//Before changing largest, save its old value into secondLargest.
                 {
                    // thirdLargest = secondLargest;
                     secondLargest = largest;
                     largest = i;
                 }
                 else if (i > secondLargest && i != largest)
                 {
                    secondLargest = i;
                 }

             }

             Console.WriteLine($"Large: {largest}");
             Console.WriteLine($"Second: {secondLargest}");
             //Console.WriteLine($"Third: {thirdLargest}");*/

            //Find the third largest...
            /* int[] numbers = new int[5];//int[] numbers = { 5, 8, 2, 10, 3 };
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Enter numbers.");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());
             }
             int largest = int.MinValue;
             int secondLargest = int.MinValue;
             int thirdLargest = int.MinValue;

             foreach (int i in numbers)
             {
                 if (i < largest)
                 {
                     thirdLargest = secondLargest;
                     secondLargest = largest;
                     largest = i;
                 }
                 else if (i > secondLargest)
                 {
                     thirdLargest = secondLargest;
                     secondLargest = i;
                 }                
                 else if (i > thirdLargest)
                 {
                     thirdLargest = i;
                 }
             }
             Console.WriteLine($"Large: {largest}");
             Console.WriteLine($"Second: {secondLargest}");
             Console.WriteLine($"Third: {thirdLargest}");*/

            //Reverse the Array...
            /* int[] numbers = new int[5];
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Enter numbers.");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());   
             }
             Array.Reverse(numbers);

             foreach (int i in numbers)
             {
                 Console.WriteLine(i);
             }*/
            //Search Number.Ask user for 5 numbers.Enter number to search...

            /*   int[] numbers = new int[5];
               for (int i = 0; i < numbers.Length; i++)
               {
                   Console.WriteLine("Enter numbers.");
                   numbers[i] = Convert.ToInt32(Console.ReadLine());
               }

               bool found = false;
               Console.WriteLine("Search number");
               int search = Convert.ToInt32(Console.ReadLine());
               foreach (int i in numbers)
               {
                   if  (search == i)
                   {
                       found = true;
                       break;
                   } 
               }
               if (found)
               {
                   Console.WriteLine("Number found");
               }
               else
               {
                   Console.WriteLine("Not found");
               }*/
            //Count Even and Odd Numbers...
            /* int[] numbers = new int[6];
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Enter numbers.");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());
             }
             int evenCount = 0;
             int oddCount = 0;
             foreach (int i in numbers)
             {
                 if (i % 2 == 0)
                  evenCount++; 

                 else if (i % 2 != 0)
                  oddCount++;

              }
             Console.WriteLine("Even: " +evenCount);
             Console.WriteLine("Odd: " +oddCount);*/

            //Smallest and Largest Together...
            /* int[] numbers = new int[5];
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Enter numbers");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());

             }
             int smallest = numbers[0];
             int largest = numbers[0];

             foreach (int i in numbers)
             {
                 if (i < smallest )
                     smallest = i;

                 else if (i > largest )
                     largest = i;
             }
             Console.WriteLine(smallest);
             Console.WriteLine(largest);*/

            //Duplicate Checker...

            /*   int[] numbers = new int[5];
               for (int i = 0; i < numbers.Length; i++)
               {
                   Console.WriteLine("Enter numbers.");
                   numbers[i] = Convert.ToInt32(Console.ReadLine());
               }
              List<int> seen = new List<int>();//through list...

               foreach (int num in numbers)
               {
                   if (seen.Contains(num))
                   {
                       Console.WriteLine("Duplicate found: " + num);
                   }
                   else
                   {
                       seen.Add(num);
                   }
               }
               HashSet<int> seen = new HashSet<int>();//through hashset...

               foreach (int num in numbers)
               {
                   if (seen.Contains(num))
                   {
                       Console.WriteLine("Duplicate found: " + num);
                   }
                   else
                   {
                       seen.Add(num);
                   }
               }*/


            /* int[] numbers = new int[5];

             HashSet<int> seen = new HashSet<int>();
             HashSet<int> duplicates = new HashSet<int>();

             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Enter number:");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());

                 if (seen.Contains(numbers[i]))
                 {
                     duplicates.Add(numbers[i]);
                 }
                 else
                 {
                     seen.Add(numbers[i]);
                 }
             }

             Console.WriteLine("Duplicate numbers:");

             foreach (int num in duplicates)
             {
                 Console.WriteLine(num);
             }*/

            //ask the user to enter 5 numbers. If a number has been previously entered,
            //display an error message and ask the user to re-try...

            int[] numbers = new int [5];
            HashSet<int> uniquenumbers = new HashSet<int>();
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("enter numbers");
                int input = Convert.ToInt32(Console.ReadLine());

                if (uniquenumbers.Contains(input))
                {
                    Console.WriteLine("Try another number.");
                }
                else
                {
                    numbers[count] = input;
                    uniquenumbers.Add(input);
                    count++;
                  }
            }
            Console.WriteLine("Sorted numbers");
            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


           



            //Sort Names Alphabetically...

          /*  Console.WriteLine("Enter the number");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input < 0)
            {
                Console.WriteLine("enter positive number");
                input = Convert.ToInt32(Console.ReadLine());
            }*/
            
            

            






        }

    }
}
