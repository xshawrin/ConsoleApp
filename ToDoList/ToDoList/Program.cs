using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> todos = new List<ToDo>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Todo Menu ---");
                Console.WriteLine("\n1. Add Todo");
                Console.WriteLine("\n2. Show Todo");
                Console.WriteLine("\n3. Mark Todo as done");
                Console.WriteLine("\n4. Remove Todo");
                Console.WriteLine("\n0. Exit");
                Console.WriteLine("Choose an option");

                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1": AddToDo(todos);break;
                    case "2": ToDoList(todos);break;     
                    case "3": DoneTodo(todos);break;
                    case "4": RemoveTodo(todos);break;
                    case "0":
                        running = false;
                        Console.WriteLine("Good bye");
                        break;

                    default: Console.WriteLine("Invalid Input");break;

                }
            }
        }
        static int ReadInt(string message)
        {
            Console.WriteLine(message);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value));
            {
                Console.WriteLine("Invalid input. Try again: ");
            }
            return value;
        }
        static void AddToDo(List<ToDo> todos)
        {
            Console.Write("Enter a Todo title: ");
            string Title = Console.ReadLine();

            int id = todos.Count + 1;

            todos.Add(new ToDo(id, Title));
            Console.WriteLine("Todo added!");
        }
        static void ToDoList(List<ToDo> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No Todo list are found.");
                return;
            } 
            foreach (var t in todos)
            {
                Console.WriteLine(t.ShowInfo());
            }
        }
        static void DoneTodo(List<ToDo> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No Todo list are found.");
                return;
            }
            int id = ReadInt("Enter Todo Id to mark as done: ");

        }
            
    }
    class ToDo
    {
        public int Id { get;}
        public string Title { get; set;}
        public bool IsDone { get; set;}

        public ToDo(int id, string title)
        {
            Id = id;
            Title = title;
            IsDone = false;

        }
        public string ShowInfo()
        {
            string status = IsDone ? "Done" : "Not done";
            return $"Id: {Id}, Title: {Title}, status: {status}";
        }
    }
}
