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
        private readonly IList<Employee> _employees;

        public EmployeeList(IList<Employee> employees)
        {
            _employees = employees;
        }


        internal override Iterator CreateIterator()
        {
            return new ListIterator(this);
        }

        internal override int Count => _employees.Count;
        internal override object this[int index] => _employees[index];
    }
}