using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
            //int[] numbers = new int[5];
            //for (int i = 0;i < numbers.Length;i++)
            //{
            //    Console.WriteLine("Enter numbers");
            //    numbers[i] =Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (int i in numbers)
            //{
            //    if (i == numbers[i])
            //    {
            //        Console.WriteLine("Retry");
            //    }
            //    Console.WriteLine(i);
            //}


         
           
                

           
           
        }
    }
}
