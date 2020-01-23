// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Builder
{
    internal class Director
    {
        private readonly EmployeeBuilder _employeeBuilder;

        public Director(EmployeeBuilder employeeBuilder)
        {
            _employeeBuilder = employeeBuilder;
        }

        internal void Construct()
        {
            _employeeBuilder.SetName();
            _employeeBuilder.SetPosition();
            _employeeBuilder.SetSalary();
        }
    }
}