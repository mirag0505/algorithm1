using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class DynArray<T>
    {
        public T[] array;
        public int count;
        public int capacity;
        readonly int MIN_RANGE = 16;

        public DynArray()
        {
            count = 0;
            MakeArray(MIN_RANGE);
        }

        public void MakeArray(int new_capacity)
        {
            capacity = new_capacity;

            if (count == 0)
            {
                array = new T[new_capacity]; return;
            }

            T[] newArray = new T[new_capacity];

            if (array.Length >= newArray.Length)
            {
                Array.Copy(array, newArray, newArray.Length);
            }
            else
            {
                Array.Copy(array, newArray, array.Length);
            }


            array = newArray;
        }

        public T GetItem(int index)
        {
            if (index > count || index < 0) throw new ArgumentOutOfRangeException("Недопустимый индекс массива");

            return array[index];
        }

        public void Append(T itm)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                MakeArray(capacity);
            }
            array[count] = itm;
            count++;
        }

        public void Insert(T itm, int index)
        {
            if (index > count || index < 0) throw new ArgumentOutOfRangeException("Недопустимый индекс массива");

            if (count == capacity || index == capacity)
            {
                capacity *= 2;
                MakeArray(capacity);
            }

            for (int i = capacity; i >= index; i--)
            {
                if (i + 1 < capacity)
                {
                    array[i + 1] = array[i];
                }
            }

            array[index] = itm;
            count++;
        }

        public void Remove(int index)
        {
            if (index > count || index < 0) throw new ArgumentOutOfRangeException("Недопустимый индекс массива");

            if (count <= (int)(capacity / 2))
            {
                capacity = (int)(capacity / 1.5);

                if (capacity < MIN_RANGE) capacity = MIN_RANGE;

                MakeArray(capacity);
            }

            for (int i = index; i < count; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }

    }
}