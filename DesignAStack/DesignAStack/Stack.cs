using System;
using System.Collections.Generic;

namespace DesignAStack
{
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("No null objects can be passed.");

            _stack.Add(obj);

        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("No objects to remove");

            var lastItem = _stack.Count - 1;

            var returnObject = _stack[lastItem];

            _stack.RemoveAt(lastItem);

            return (returnObject);
        }

        public void Clear()
        {
            _stack.Clear();
        }
      

    }
}