// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Builder
{
    /// <summary>
    /// The Builder abstract class specifies methods for creating the different parts
    /// of the Employee objects.
    /// </summary>
    internal abstract class EmployeeBuilder 
    {
        protected Employee Employee { get; }

        protected EmployeeBuilder()
        {
            Employee = new Employee();
        }

        internal abstract EmployeeBuilder SetName(string name);
        internal abstract EmployeeBuilder SetPosition(string position);
        internal abstract EmployeeBuilder SetSalary(double salary);
        internal abstract Employee Build();
    }
}