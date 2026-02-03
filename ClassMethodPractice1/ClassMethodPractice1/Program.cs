using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Student>students = new List<Student>();

            students.Add (new Student ( 1, "Shuchita", 35 ));//using constructor
            students.Add(new Student (2, "Niaz", 16 ));

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n ---- Student Menu ----");
                Console.WriteLine("\n1. Student List");
                Console.WriteLine("\n2. Add Student");
                Console.WriteLine("\n3. Remove Student");
                Console.WriteLine("\n4. Update Student");
                Console.WriteLine("\n0. Exit");
                Console.Write("\nChoose option: ");

                string choice = Console.ReadLine();
               
                switch (choice)
                {
                    case "1":
                        PrintStudents(students);
                        break;

                    case "2":
                        AddStudent(students);
                        break;

                    case "3":
                        RemoveStudent(students);
                        break;

                    case "4":
                        UpdateStudent(students);
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
       
           /* foreach (Student s in students)
            {
                s.PrintInClass();
            }*/

            /* Console.WriteLine(student1.ShowInfo());
             Console.WriteLine(student2.ShowInfo());
             student1.PrintAdult();
             student2.PrintAdult();*///(without list)

            /*foreach (Student s in students)
            {
                Console.WriteLine(s.ShowInfo());
                s.PrintAdult();
            }*///if we not add in method


            // PrintStudents(students);//calling the method from outside of the class

            // student2.ShowInfo();//it works if method has printed
        }
        static void PrintStudents(List<Student> students)//method of printing all students since its printing all student, can not be the part of Student class
        {
            if(students.Count == 0)
            {
                Console.WriteLine("No student found");
                return;
            }
            foreach (Student s in students)
            {
                Console.WriteLine(s.ShowInfo());
                s.PrintAdult();
            }
        }
        static void AddStudent(List<Student> students)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student age: ");
            int age;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid age");
                return;
            }

            Console.Write("Enter Student ID: ");
            
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID");
                return;
            }
            students.Add(new Student(id, name, age));
            Console.WriteLine("Studaent added successfully");
        }
        static void RemoveStudent(List<Student> students)
        {
    

            Console.Write("Enter Student ID: ");
            
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID");
                return;
            }
            Student studentToRemove = null;
            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    studentToRemove = s;
                    break;
                }
            }
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        static void UpdateStudent(List<Student> students)
        {
            
            Console.WriteLine("Enter student ID to update");
            
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID");
                return;
            }  
            Student studentToUpdate = null;
            foreach (Student s in students)
            { if (s.Id == id)
                {
                    studentToUpdate = s;
                    break;
                }
            }
            if (studentToUpdate != null)
            {
                Console.Write("Enter new name: ");
                studentToUpdate.Name = Console.ReadLine();

                Console.WriteLine("Enter student age: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Invalid age"); 
                    return ;
                }
               studentToUpdate.Age = age;
                Console.WriteLine("Student updated successfully.");

            }
                 


        }

    }

    class Student //class is a blueprint of particular object
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
       // public string Email { get; set; }

        //constructor
        public Student(int id, string name,  int age)
        {
            Id = id;
            Name = name;
            Age = age;
             
        }

        //method
        public string ShowInfo()
        {
            return $"Name: {Name}, Age: {Age}, ID: {Id}";// need to print in a main
            //Console.WriteLine($"Name: {Name}, Age: {Age}, ID: {Id}");
            //if its void print here works
        }
        public bool IsAdult()
        {
            return Age >= 18;
        }
        public void PrintAdult()
        {
            Console.WriteLine($"{Name}:{IsAdult()}");
        
        }
        public void PrintInClass()
        {
            Console.WriteLine(ShowInfo());
            PrintAdult();
        }
       

    }

   
}

