// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Builder
{
    /// <summary>
    /// The Concrete Builder classes follow the Builder abstract class and provide
    /// specific implementations of the building steps. Your program may have
    /// several variations of Builders, implemented differently.
    /// </summary>
    internal class DeveloperBuilder : EmployeeBuilder
    {
        internal override EmployeeBuilder SetName(string name)
        {
            Employee.Name = name;
            return this;
        }

        internal override EmployeeBuilder SetPosition(string position)
        {
            Employee.Position = position;
            return this;
        }

        internal override EmployeeBuilder SetSalary(double salary)
        {
            Employee.Salary = salary;
            return this;
        }

        internal override Employee Build()
        {
            return Employee;
        }
    }
}