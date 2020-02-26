// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace TemplateMethod
{
    /// <summary>
    /// The Abstract Class defines a template method that contains a skeleton of
    /// some algorithm, composed of calls to (usually) abstract primitive
    /// operations.
    /// Concrete subclasses should implement these operations, but leave the
    /// template method itself intact.
    /// </summary>
    internal abstract class Interview
    {
        /// <summary>
        /// The template method defines the skeleton of an algorithm.
        /// </summary>
        internal void Initiate()
        {
            Start();
            Test();
            Discuss();
            Finish();
        }

        /// <summary>
        /// These operations already have implementations.
        /// </summary>
        protected virtual void Start()
        {
            Console.WriteLine("Start interview.");
        }

        protected virtual void Finish()
        {
            Console.WriteLine("Finish interview.");
        }

        /// <summary>
        /// These operations have to be implemented in subclasses.
        /// </summary>
        protected abstract void Test();
        protected abstract void Discuss();
    }
}