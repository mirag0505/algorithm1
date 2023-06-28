using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Queue<T>
    {
        private LinkedList<T> linkedList;
        public Queue()
        {
            linkedList = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            linkedList.AddLast(item);
        }

        public T Dequeue()
        {
            if (linkedList.Count > 0)
            {
                var firstElement = linkedList.First();
                linkedList.RemoveFirst();
                return firstElement;
            }

            return default(T);
        }

        public int Size()
        {
            return linkedList.Count;
        }
    }
}