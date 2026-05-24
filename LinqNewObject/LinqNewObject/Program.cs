using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqNewObject
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> {
              new Employee { Name = "John", Department = "IT", Salary = 6000 },
             new Employee { Name = "Sara", Department = "HR", Salary = 4000 },
             new Employee { Name = "Mike", Department = "IT", Salary = 7000 },
             new Employee { Name = "Emma", Department = "Finance", Salary = 8000 }
            };

            var highestDepartment = employees
    .GroupBy(e => e.Department)
    .Select(group => new
    {
        Department = group.Key,
        TotalSalary = group.Sum(e => e.Salary)
    })
    .OrderByDescending(x => x.TotalSalary)
    .First();

            //Annual Salary Projection...& find highest annual salary...
            var Salary = employees
                .Select(e => new
                {
                    e.Name,
                    e.Department,
                    e.Salary,
                    AnnualSalary = e.Salary * 12
                })
                .OrderByDescending(x => x.AnnualSalary)
               // .First();
               .Where(a=> a.AnnualSalary > 70000 && a.Department == "IT");

            foreach(var emp in Salary)
            {
                Console.WriteLine($"{emp.Name}");
            }
          //  Console.WriteLine($"{Salary.Name} - {Salary.Department} - {Salary.AnnualSalary}");
          /* foreach (var emp in Salary)
            {
                Console.WriteLine($"{emp.Name} - {emp.Department}- { emp.annualSalary}");
            }*/

        }



    }
}
