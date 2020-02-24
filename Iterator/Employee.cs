// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Iterator
{
    /// <summary>
    /// Our collection item.
    /// </summary>
    internal class Employee
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal int Age { get; set; }
        internal string Position { get; set; }

        public Employee(string firstName, string lastName, int age, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}, Position: {Position}";
        }
    }
}