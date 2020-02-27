// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// The client code may or may not know about the Concrete Iterator
    /// or Collection classes, depending on the level of indirection you
    /// want to keep in your program.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee("Ken", "Black", 30, "Manager"),
                new Employee("Jack", "White", 35, "Officer"),
                new Employee("Bruno", "Mars", 37, "Developer"),
                new Employee("Abraham", "Blood", 23, "Developer")
            };
            var employeeList = new EmployeeList(employees);
            var employeeListIterator = employeeList.CreateIterator();
            if (employeeList.Count > 0)
            {
                Console.WriteLine("--- Employees ---");
                for (employeeListIterator.First(); employeeListIterator.HasNext(); employeeListIterator.Next())
                {
                    var employee = employeeListIterator.GetCurrentItem() as Employee;
                    Console.WriteLine(employee.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
