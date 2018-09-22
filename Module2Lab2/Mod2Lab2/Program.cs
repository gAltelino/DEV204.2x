using System;

namespace Mod2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

var employee1 = new Employee("Libby", 2000);
var employee2 = new TechnicalEmployee("Zaynah");
var employee3 = new BusinessEmployee("Winter");

Console.WriteLine(employee1.EmployeeStatus());
Console.WriteLine(employee2.EmployeeStatus());
Console.WriteLine(employee3.EmployeeStatus());

        }
    }
}
