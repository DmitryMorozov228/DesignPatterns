// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Builder
{
    internal class DeveloperBuilder : EmployeeBuilder
    {
        internal override void SetName()
        {
            Employee.Name = "Chen Kim";
        }

        internal override void SetPosition()
        {
            Employee.Position = ".NET Developer";
        }

        internal override void SetSalary()
        {
            Employee.Salary = 20.2;
        }

        internal override Employee Build()
        {
            return Employee;
        }
    }
}