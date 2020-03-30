// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace FluentBuilder
{
    internal class Employee
    {
        internal string Name { get; set; }
        internal string Position { get; set; }
        internal double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}, Salary: {Salary}";
        }
    }
}