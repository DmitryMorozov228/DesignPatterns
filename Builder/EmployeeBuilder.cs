// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Builder
{
    internal abstract class EmployeeBuilder 
    {
        protected Employee Employee { get; }

        protected EmployeeBuilder()
        {
            Employee = new Employee();
        }

        internal abstract void SetName();
        internal abstract void SetPosition();
        internal abstract void SetSalary();
        internal abstract Employee Build();
    }
}