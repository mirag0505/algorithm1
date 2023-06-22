using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Stack<T>
    {
        public LinkedList<T> linkedList;
        public Stack()
        {
            LinkedList<T> newLinkedList = new LinkedList<T>();
            linkedList = newLinkedList;
        }

        public int Size()
        {
            return linkedList.Count;
        }

        public T Pop()
        {
            if (linkedList.Count == 0) return default(T);


            var popedFirstElement = linkedList.First();
            linkedList.RemoveFirst();
            return popedFirstElement;
        }

        public void Push(T val)
        {
            linkedList.AddFirst(val);
        }

        public T Peek()
        {
            if (linkedList.Count == 0) return default(T);

            return linkedList.First();
        }
    }
}