using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle bicycle = new Bycicle();
            Vehicle truck = new Truck();
            car.Drive();
            bicycle.Drive();
            truck.Drive();

           /* Teacher teacher = new Teacher("Niaz", 40); //without constructor
            //student.name = "Niaz"; without encapsulation
            //student.age = 40;
            //Person.SetDetails("Niaz", 40); //with encapsulation
           // teacher.Introduction();
            //if (person.IsAdult())
            //{
            //    Console.WriteLine($" is adult.");
            //}
            //teacher.Teach();*/
        }
    }
    class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving.");
        }
    }
    class Bycicle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bycle is moving slowly.");
        }
    }
    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is moving fast.");
        }
    }
    class Truck : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Truck is carrying heavy load.");
        }
    }
    /* class Person
     {
        public string Name { get; private set; }
        private  int Age { get; set; }

         //public void SetDetails(string stuname, int stuage) // Encapsulation
         //{
         //    name = stuname;
         //    age = stuage;
         //}
         public Person(string name, int age) 
         {
             Name = name;
             Age = age;
         }

         public void Introduction()
         {
             Console.WriteLine($"My name is {Name} and I am {Age} years old.");
         }
     }
         class Teacher : Person
     {
         public Teacher(string name, int age) : base(name, age) 
         { 
         }
         public void Teach()
         {
             Console.WriteLine($"{Name} teaches Math.");
         }


         //public void IsAdult()
         //{
         //    if (age >= 18)
         //    {
         //       Console.WriteLine($"{name} is adult.");
         //    }
         //    else
         //    {
         //        Console.WriteLine($"{name} is not adult.");
         //    }
         //}

         //public bool IsAdult()
         //{
         //    return age > 18;
         //}
     }*/
}
