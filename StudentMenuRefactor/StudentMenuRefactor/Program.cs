using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace StudentMenuRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student>students = new List<Student>();
            students.Add(new Student(1, "Shuchita", 25));
            students.Add(new Student(2, "Niaz", 18));

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n ---- Student Menu ----");
                Console.WriteLine("\n1. Student List");
                Console.WriteLine("\n2. Add Student");
                Console.WriteLine("\n3. Remove Student");
                Console.WriteLine("\n4. Update Student");
                Console.WriteLine("\n5. Find Student by name");
                Console.WriteLine("\n6. Total Student");
                Console.WriteLine("\n0. Exit");
                Console.Write("\nChoose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        foreach (var s in students)
                            s.PrintStudent();
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

                    case "5":
                        FinStudentByName(students);
                        break;

                    case "6":
                        ShowStudentCount(students);
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }

               
            }
        }
        static bool IsIdExist(List<Student>students, int id)
        {
            foreach(var s in students)
            {
                if (s.Id == id)
                    return true;
            }
            return false;
        }
        static int ReadInt(string message)
        {
            Console.Write(message);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input. Try again: ");
            }
            return value;
        }
        static bool HasStudent(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No student available");
                return false;
            }
            return true;
        }

        static Student FindStudentById(List<Student> students, int id)
        {
            foreach (var s in students)
            {
                if (s.Id == id)
                    return s;
            }
            return null;
        }
        static void FinStudentByName(List<Student> students)
        {
            if (!HasStudent(students))
                return;
            Console.WriteLine("Enter student name to search: ");
            string name = Console.ReadLine();

            bool found = false;
            foreach (var s in students)
            {
                if (s.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(s.ShowInfo());
                    found = true;
                } 
            }
            if(!found)
                Console.WriteLine("No student found with this name.");
        }
        static void ShowStudentCount(List<Student> students)
        {
            Console.WriteLine($"Total students: {students.Count}");
        }
        
        static void AddStudent(List<Student> students)
        {
           
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            int id = ReadInt("Enter ID: ");
            if (IsIdExist(students, id))
            { Console.WriteLine("A student with this ID already exist");
                return;
            }

            int age = ReadInt("Enter Age: ");

            students.Add(new Student(id, name, age));
            Console.WriteLine("Student added successfully");
            
        }


        static void RemoveStudent(List<Student> students)
        {
            if (!HasStudent(students))
                return;

            int id = ReadInt("Enter ID: ");
            Student student = FindStudentById(students, id);
            if (student == null)
            {
                Console.WriteLine("No student found.");
                return;
            }
            Console.WriteLine($"Are you sure you want to delete {student.Name}? (y/n):");
            string confirm = Console.ReadLine();

            if (confirm.ToLower() == "y")
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Delete cancelled.");
            }
        }

        static void UpdateStudent(List<Student> students)
        {
            if (!HasStudent(students))
                return;
            int id = ReadInt("Entr ID to update: ");
            Student student = FindStudentById(students,id);

            if (student == null)
            { Console.WriteLine("No student found."); 
            return;}
            Console.Write("Enter new name: ");
            student.Name = Console.ReadLine();

            student.Age = ReadInt("Enter new student age: ");
            Console.WriteLine("Studnet successfully updated.");

        }

    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        //method

        public string ShowInfo()
        {
            return($"ID: {Id}, Name: {Name}, Age: {Age}");
            
        }
        public bool IsAdult()
        {
            return (Age >= 20);
        }

        public void PrintStudent()
        {
            Console.WriteLine(ShowInfo());
         Console.WriteLine($"{Name}: {IsAdult()}");
        }

    }
}

