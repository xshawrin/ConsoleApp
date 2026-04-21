using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UdemiIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----Condition----

            /*Write a program and ask the user to enter a number.The number 
            should be between 1 to 10.If the user enters a valid number 
            display "Valid" on the console.Otherwise, display "Invalid". 
            (This logic is used a lot in applications where values entered 
            into input boxes need to be validated.)*/

            //Console.WriteLine("Enter a number between 1 and 10: ");
            //int input = int.Parse(Console.ReadLine());

            //if (input >= 1 && input <= 10)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}


            /*Write a program which takes two numbers from the console and
            displays the maximum of the two.*/

            //Console.WriteLine("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine(" The maximum number is: " + num1);
            //}
            //else
            //{
            //    Console.WriteLine("The maximum is: " + num2);
            //}


            /* Write a program and ask the user to enter the width and height
             of an image. Then tell if the image is landscape or portrait.*/

            //Console.Write("Enter the height of the image: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the width of the image: ");
            //double width = Convert.ToDouble(Console.ReadLine());

            //if (height > width)
            //{
            //    Console.WriteLine("Portrait");
            //}
            //else
            //{
            //    Console.WriteLine("Landscape");
            //}


            /* Your job is to write a program for a speed camera.For simplicity,
             ignore the details such as camera, sensors, etc and focus purely 
             on the logic.Write a program that asks the user to enter the speed
             limit.Once set, the program asks for the speed of a car.If the user 
             enters a value less than the speed limit, program should display
             Ok on the console.If the value is above the speed limit, the 
             program should calculate the number of demerit points.For every
             5km / hr above the speed limit, 1 demerit points should be 
             incurred and displayed on the console.If the number of demerit
             points is above 12, the program should display License Suspended.*/

            //Console.Write("Enter the camera speed: ");
            //double speed = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the speed limit: ");
            //double speedLimit = Convert.ToDouble(Console.ReadLine());

            //if (speed < speedLimit)
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    double extraspeed = speed - speedLimit;
            //    double demeritsPoint = extraspeed / 5;

            //    if (demeritsPoint > 12)
            //    {
            //        Console.WriteLine("License Suspended.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Demerit Point: " + demeritsPoint);
            //    }

            //}


            // ----Loops----

            /* Write a program to count how many numbers between 1 and 100 are
             divisible by 3 with no remainder.Display the count on the 
             console.*/



            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            /* Write a program and continuously ask the user to enter a number
             or "ok" to exit. Calculate the sum of all the previously 
             entered numbers and display it on the console.*/

            //int sum = 0;
            // while(true)
            // {
            //     Console.Write("Enter a number or 'ok' to stop: ");
            //     string input= Console.ReadLine();

            //     if (input.ToLower() == "ok")
            //         break;

            //    if(int.TryParse(input, out int result))
            //     {

            //         sum += result;
            //     }
            //    else
            //     {
            //         Console.WriteLine("Invalid input, Try again.");
            //     }

            //     Console.WriteLine("Total: " + sum);

            // }

            /*Write a program and ask the user to enter a number.
            Compute the factorial of the number and print it on the 
            console. For example, if the user enters 5, the program 
            should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/

            //Console.WriteLine("Enter a number");
            //int input = int.Parse(Console.ReadLine());

            //long factorial = 1;

            //for (int i = 1; i <= input; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(input + "!= " + factorial);


            /*Write a program that picks a random number between 1 and 10.
            Give the user 4 chances to guess the number.If the user guesses
            the number, display “You won"; otherwise, display “You lost" 
            (To make sure the program is behaving correctly, you can
            display the secret number on the console first.)*/


            //var random = new Random();
            //int NumberToGuess = random.Next(1, 10);
            //Console.WriteLine(NumberToGuess);

            //int attempts = 0;
            //int MaxAttempts = 4;
            //while (attempts < MaxAttempts)
            //{
            //    attempts++;

            //    Console.WriteLine("Pick a random number between 1 to 10: ");
            //    int input = int.Parse(Console.ReadLine());

            //    if (input == NumberToGuess)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You lost!");
            //        Console.WriteLine($"You have {MaxAttempts - attempts} more attempts left!");
            //    }

            //}
            //Console.WriteLine("Thank you for playing");


            /*  Write a program and ask the user to enter a series of numbers 
            separated by comma. Find the maximum of the numbers and display it 
            on the console. For example, if the user enters “5, 3, 8, 1, 4", 
            the program should display 8.*/

            Console.WriteLine("Enter a series of numbers separated by coma" +
                " to find maximum of the number");
            int input =int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            if (input > maxNum)
            {
                maxNum = input;
            }
            Console.WriteLine(maxNum);
                
             



         


            /* var timespan = new TimeSpan(1, 0, 0);
             //var timespan = TimeSpan.FromHours(1);
             //Console.WriteLine(timespan);
             string FullName = " Shuchita Shawrin  ";
             Console.WriteLine(FullName.Trim(' '));*/










        }
    }
}
