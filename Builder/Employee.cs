// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Builder
{
    /// <summary>
    /// It makes sense to use the Builder pattern only when your products are
    /// quite complex and require extensive configuration.
    /// </summary>
    internal class Employee
    {
        internal string Name { get; set; }
        internal string Position { get; set; }
        internal double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name ?? "Unknown"}\nPosition: {Position ?? "Unknown"}\nSalary: {Salary}$";
        }
    }
}