// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// The ConcreteAggregate class
    /// Concrete Collections provide one or several methods for retrieving fresh
    /// iterator instances, compatible with the collection class.
    /// </summary>
    internal class EmployeeList : StaffCollection
    {
        private readonly List<Employee> _employees;

        public EmployeeList()
        {
            _employees = new List<Employee>
            {
                new Employee("Ken", "Black", 30, "Manager"),
                new Employee("Jack", "White", 35, "Officer"),
                new Employee("Bruno", "Mars", 37, "Developer"),
                new Employee("Abraham", "Blood", 23, "Developer")
            };
        }


        internal override Iterator CreateIterator()
        {
            return new ListIterator(this);
        }

        internal override int Count => _employees.Count;
        internal override object this[int index] => _employees[index];
    }
}