// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    internal class ListIterator : Iterator
    {
        private readonly StaffCollection _employees;
        private int _current;

        public ListIterator(StaffCollection employees)
        {
            _employees = employees;
            _current = 0;
        }

        internal override void First()
        {
            _current = 0;
        }

        internal override void Next()
        {
            _current++;
        }

        internal override bool HasNext()
        {
            return _current < _employees.Count;
        }

        internal override object GetCurrentItem()
        {
            return _employees[_current];
        }
    }
}