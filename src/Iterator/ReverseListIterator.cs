// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    internal class ReverseListIterator : Iterator
    {
        private readonly StaffCollection _employees;
        private int _current;

        public ReverseListIterator(StaffCollection employees)
        {
            _employees = employees;
            _current = employees.Count - 1;
        }

        internal override void First()
        {
            _current = _employees.Count - 1;
        }

        internal override void Next()
        {
            _current--;
        }

        internal override bool HasNext()
        {
            return _current >= 0;
        }

        internal override object GetCurrentItem()
        {
            return _employees[_current];
        }
    }
}