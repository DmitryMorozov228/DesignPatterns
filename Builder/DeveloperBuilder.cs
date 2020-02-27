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
        internal override EmployeeBuilder SetName()
        {
            Employee.Name = "Chen Kim";
            return this;
        }

        internal override EmployeeBuilder SetPosition()
        {
            Employee.Position = ".NET Developer";
            return this;
        }

        internal override EmployeeBuilder SetSalary()
        {
            Employee.Salary = 20.2;
            return this;
        }

        internal override Employee Build()
        {
            return Employee;
        }
    }
}