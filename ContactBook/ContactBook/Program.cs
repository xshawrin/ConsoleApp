using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PhoneBook> contacts = new List<PhoneBook>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n------ PhoneBook Menu -----");
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("\n2. Show Contact");
                Console.WriteLine("\n3. Remove Contact");
                Console.WriteLine("\n4. Search Contact");
                Console.WriteLine("\n5. Update Contact");
                Console.WriteLine("\n0. Exit menu");
                Console.Write("\nChoose an iption: ");

                

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddContact(contacts);
                        break;
                    case "2":
                        ShowContact(contacts);
                        break;
                    case "3":
                        RemoveContact(contacts);
                        break;
                    case "4":
                        SearchContact(contacts);
                        break;
                    case "5":
                        UpdateContact(contacts);
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exiting phonebook!");
                        break;

                    default: Console.WriteLine("Invalid choice");
                        break;

                }
            }

        }


        static void AddContact(List<PhoneBook> contacts)
        {
            int id = contacts.Count + 1;

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter contact number");
            int number = int.Parse(Console.ReadLine());

            contacts.Add(new PhoneBook(id, name, number));
            Console.WriteLine("Contact added successfully in phonebook");
        }
        static void ShowContact(List<PhoneBook> contacts)
        {
            foreach(PhoneBook c in contacts)
                Console.WriteLine( c.ShowInfo());

        }

        static void RemoveContact(List<PhoneBook> contacts)
        {
            Console.WriteLine("Enter the name to remove");
            string name = Console.ReadLine();

            PhoneBook contact = contacts.Find(c => c.name.ToLower() == name.ToLower());
             if (contact != null)
            { 
                Console.WriteLine($"Are you sure you want to remove '{name}' from contact? (Y/N): ");
                string confirm = Console.ReadLine();
                if (confirm.ToLower() == "y")
                { contacts.Remove(contact);
                    for (int i = 0; i < contacts.Count; i++)
                    {
                        contacts[i].id = i + 1;
                    }
                    Console.WriteLine("contact deleted successfully");
                }
                else
                {
                    Console.WriteLine("Delete cancelled");
                }
                return;

            }
             else
            {
                Console.WriteLine("No contact found!");
            }
        }

        static void SearchContact(List<PhoneBook> contacts)
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            PhoneBook contact = contacts.Find(c => c.name.ToLower() == name.ToLower());
            if (contact != null)
            {
                Console.WriteLine($" {contact.id}. {contact.name}- {contact.number}");
            }
            else
            { Console.WriteLine("No contact found!"); }
        }

        static void UpdateContact(List<PhoneBook> contacts)
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            PhoneBook contact = contacts.Find(c => c.name.ToLower() == name.ToLower());
            if (contact != null)
            {
                Console.WriteLine(" Enter new number or name to update");
                contact.number = int.Parse(Console.ReadLine());

            }
            else { Console.WriteLine("No name found!"); }

        }

    }
    class PhoneBook
    {
        public int id { get; set; }
        public string name { get; set; }
        public int number { get; set; }

        public PhoneBook(int id, string name, int number)
        {
            this.id = id;
            this.name = name;
            this.number = number;

        }

        public string ShowInfo()
        {
            return ($"{id}. {name}: {number}");
        }
    }
}
