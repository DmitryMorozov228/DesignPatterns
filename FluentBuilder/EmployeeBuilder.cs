// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace FluentBuilder
{
    internal class EmployeeBuilder
    {
        private readonly Employee _employee;

        public EmployeeBuilder()
        {
            _employee = new Employee();
        }

        internal EmployeeBuilder SetName(string name)
        {
            _employee.Name = name;
            return this;
        }

        internal EmployeeBuilder SetPosition(string position)
        {
            _employee.Position = position;
            return this;
        }

        internal EmployeeBuilder SetSalary(double salary)
        {
            _employee.Salary = salary;
            return this;
        }

        internal Employee Build()
        {
            return _employee;
        }
    }
}