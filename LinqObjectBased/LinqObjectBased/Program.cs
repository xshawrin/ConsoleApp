using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjectBased
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
     }
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public List<string> Items { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
 {
     new Product { Id = 1, Name = "Laptop", Price = 1200 },
     new Product { Id = 2, Name = "Mouse", Price = 25 },
     new Product { Id = 3, Name = "Keyboard", Price = 75 },
     new Product { Id = 4, Name = "Monitor", Price = 300 }
    };
            /* var greater100 = products.Where(p => p.Price > 100);
             foreach (var product in greater100) 
             Console.WriteLine(product.Name);

             var allNames = products.Select(p => p.Name).ToList();
             foreach(var product in allNames)
             Console.WriteLine(product);

             var sortPrice = products.OrderBy(p => p.Price);
             foreach (var product in sortPrice)
                 Console.WriteLine($"{product.Name} - {product.Price}");
           
            var expensiveProduct2 = products.OrderByDescending(p => p.Price)
                .Take(2);
            foreach (var product in expensiveProduct2)
            {
                Console.WriteLine(product.Name); }*/

             List<Employee> employees = new List<Employee> { 
              new Employee { Name = "John", Department = "IT", Salary = 6000 },
             new Employee { Name = "Sara", Department = "HR", Salary = 4000 },
             new Employee { Name = "Mike", Department = "IT", Salary = 7000 },
             new Employee { Name = "Emma", Department = "Finance", Salary = 8000 }
        };
            /* var highestITSalary = employees.Where(e => e.Salary > 6000 && e.Department == "IT").ToList();

                foreach (var employee in highestITSalary)
                    Console.WriteLine(employee.Name);
                var groupDepartment = employees.GroupBy(e => e.Department);
                foreach (var group in groupDepartment)
                {
                    Console.WriteLine(group.Key);

                    foreach (var name in group)
                    {
                        Console.WriteLine($"  {name.Name}");
                    }
                }

                //Find highest...
                 var totalSalary = employees.Sum(e=> e.Salary);
                   Console.WriteLine(totalSalary);
                   var highestPaid = employees.OrderByDescending(e => e.Salary)
                     //  .Select(e => e.Name)
                   .First();

                   Console.WriteLine(highestPaid.Name + highestPaid.Salary);
                var highestSalaryPaid = employees.Max(e=> e.Salary);
                   Console.WriteLine(highestSalaryPaid);//instead of these code...
               // var highestSalaryPaid = employees.Max(e => e.Salary);
       Console.WriteLine(highestSalaryPaid);
                var disticntDepartment = employees.Select(e => e.Department)
                .Distinct();
                foreach (var department in disticntDepartment)
                {
                    Console.WriteLine(department);*/

            //Find Employees With Salary Between 5000 and 8000...
            /*var salaryBetween = employees.Where(e => e.Salary >= 5000 && e.Salary <= 8000)
                    .Select(e => e.Name);                  
                foreach(var emp in  salaryBetween)
                    Console.WriteLine(emp);*/

            //Count Employees In Each Department...
            /* var countEmployee = employees.GroupBy(e => e.Department);
             foreach (var group in countEmployee)
             {
                 Console.WriteLine(group.Key + group.Count());
             }*/

            //Print Employee Names Inside Each Group...
            /* var departments = employees.GroupBy(e => e.Department);
             foreach (var group in departments)
             {
                 Console.WriteLine(group.Key);
                 foreach (var name in group)
                 {
                     Console.WriteLine($" -{name.Name}");
                 }
             }*/

            //Find Department With Highest Total Salary...
            /*  var highestDepartment = employees
      .GroupBy(e => e.Department)
      .Select(group => new
      {
          Department = group.Key,
          TotalSalary = group.Sum(e => e.Salary)
      })
      .OrderByDescending(x => x.TotalSalary)
      .First();

              Console.WriteLine($"{highestDepartment.Department} - {highestDepartment.TotalSalary}");*/

            // Annual Salary Projection...
            
            /* List<Order> orders = new List<Order>
    {
        new Order
        {
            Id = 1,
            Customer = "Alice",
            Items = new List<string> { "Laptop", "Mouse", "Keybord" }
        },
        new Order
        {
            Id = 2,
            Customer = "Bob",
            Items = new List<string> { "Keyboard", "Monitor" }
        }
    };
             var allItems = orders.SelectMany(o => o.Items);
             foreach (var item in allItems)
             {
                 Console.WriteLine(item);
             }
             var mostItems = orders.OrderByDescending(o => o.Items.Count)
             .First();            

                 Console.WriteLine(mostItems.Customer);

             var listItems = orders.OrderBy(o => o.Items.Count)
             .First();
             Console.WriteLine(listItems.Customer);*/


        }

    }
}
