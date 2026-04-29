using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParseMethodUdemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string NumberText = "123";
            //int number = int.Parse(NumberText);
            //Console.WriteLine(number);

            //string DateText = "2026-04-29";
            //DateTime Date = DateTime.Parse(DateText);
            //Console.WriteLine(Date);

            //string input = "123a"...Try converting to int using TryParse...
            /*string input = "123a";
            int num;
            if (int.TryParse(input, out num))
            {
                Console.WriteLine("Valid:" + num);
            }
            else
            {
                Console.WriteLine("Invalid");
            }*/

            //Ask the user for input:...
            /* int num;
             Console.WriteLine("Enter your age: ");
             string input = Console.ReadLine();
             if (int.TryParse (input, out num))
             {
                 Console.WriteLine("Succesful");

             }
             else
             {
                 Console.WriteLine("Enter a valid number.");
             }*/

            //string data = "John,30"...
            /*string data = "Jhon, 30";
            string[] parts = data.Split(',');
            parts[0] = "Jhon";
            parts[1] = "30";
            string name = parts[0];
            int age= int.Parse(parts[1]);*/


            //string product = "Laptop,999.99";
            /*string product = "Laptop,999.99";
            string[] parts = product.Split(',');
            string name = parts[0];
            double price = double.Parse(parts[1]);
            Console.WriteLine("name:" + name);
            Console.WriteLine("price:" + price);*/

            ////Create Your Own Parse Method (OOP)..Student.Parse("Alice,85");...
           /* Student s = Student.Parse("Alice, ki");
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Mark);*/
           Product p = Product.Parse("phone,8990.99,3");
            double total = p.GetTotal();
            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("Price: " + p.Price);
            Console.WriteLine("Total: " + total);


        }
    }
    //Create Your Own Parse Method (OOP)..Student.Parse("Alice,85");...
    /*  class Student
      {
          public string Name;
          public int Mark;

          public static Student Parse (string data)
          {

              string[] parts = data.Split(',');

             string name = parts[0];

             int mark;
             if(!int.TryParse(parts[1], out mark))
             {
                 Console.WriteLine("Invalid marks.");
                 mark = 0;

             }
             return new Student
             {
                 Name = name,
                 Mark = mark
             };

          }
      }*/
    //Handle invalid input inside your custom Parse.
    //Enter product details (name,price,quantity): Phone,599.99.2, Calculate total price...
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public static Product Parse (string data)
        {
            string[] parts = data.Split(',');

            return new Product
            {
                Name = parts[0],
                Price = double.Parse(parts[1]),
                Quantity = int.Parse(parts[2])

            };
            
        }
        public double GetTotal()
        {
            return Price * Quantity;
        }
    }

}

