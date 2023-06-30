using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    class Deque<T>
    {
        private LinkedList<T> linkedList;
        public Deque()
        {
            linkedList = new LinkedList<T>();
        }

        public void AddFront(T item)
        {
            linkedList.AddFirst(item);
        }

        public void AddTail(T item)
        {
            linkedList.AddLast(item);
        }

        public T RemoveFront()
        {
            if (linkedList.Count == 0) return default(T);

            T first = linkedList.First();
            linkedList.RemoveFirst();
            return first;
        }

        public T RemoveTail()
        {
            if (linkedList.Count == 0) return default(T);

            T last = linkedList.Last();
            linkedList.RemoveLast();
            return last;
        }

        public int Size()
        {
            return linkedList.Count;
        }
    }

}