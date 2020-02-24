// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

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
            var employeeList = new EmployeeList();
            var employeeListInterator = employeeList.CreateIterator();
            if (employeeList.Count > 0)
            {
                Console.WriteLine("Employees:");
                for (employeeListInterator.First(); employeeListInterator.HasNext(); employeeListInterator.Next())
                {
                    var employee = employeeListInterator.GetCurrentItem() as Employee;
                    Console.WriteLine(employee.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
