using System;
using System.Collections.Generic;

namespace InheritanceAndAssociation
{
    public class Stack 
    {
        private List<int> stackList = new List<int>();
        private int stackTop = -1;

        
        
        public void Push(object obj) 
        {
            if (obj == null)
                throw InvalidOperationException();

            stackList.Add((int)obj);
            stackTop++;
        }

        private Exception InvalidOperationException()
        {
            throw new NotImplementedException();
        }

        public object Pop() 
        {
            if (stackTop == -1)
                throw InvalidOperationException();
            var deleting_element=stackList[stackTop];
            stackList.RemoveAt(stackTop);
            stackTop--;
            return deleting_element;
        }

        public void clear() 
        {
            stackList.Clear();
            Console.WriteLine("All Element Deleted");

        }
    }
}
