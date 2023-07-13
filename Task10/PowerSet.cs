using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    // наследуйте этот класс от HashTable
    // или расширьте его методами из HashTable
    public class PowerSet<T>
    {
        private readonly List<T> elements;
        public PowerSet()
        {
            // ваша реализация хранилища
            elements = new List<T>();
        }

        public int Size()
        {
            // количество элементов в множестве
            return elements.Count;
        }

        public void Put(T value)
        {
            // всегда срабатывает
            if (!elements.Contains(value)) elements.Add(value);
        }

        public bool Get(T value)
        {
            // возвращает true если value имеется в множестве,
            // иначе false
            return elements.Contains(value);
        }

        public bool Remove(T value)
        {
            // возвращает true если value удалено
            // иначе false
            if (elements.Contains(value))
            {
                elements.Remove(value);
                return true;
            }
            return false;
        }

        public PowerSet<T> Intersection(PowerSet<T> set2)
        {
            // пересечение текущего множества и set2
            PowerSet<T> set = new PowerSet<T>();

            for (int i = 0; i < set2.elements.Count; i++)
            {
                if (elements.Contains(set2.elements[i])) set.Put(set2.elements[i]);
            }
            return set;
        }

        public PowerSet<T> Union(PowerSet<T> set2)
        {
            // объединение текущего множества и set2
            for (int i = 0; i < elements.Count; i++)
            {
                set2.Put(elements[i]);
            }
            return set2;
        }

        public PowerSet<T> Difference(PowerSet<T> set2)
        {
            // разница текущего множества и set2
            PowerSet<T> set = new PowerSet<T>();

            for (int i = 0; i < set2.elements.Count; i++)
            {
                if (elements.Contains(set2.elements[i])) elements.Remove(set2.elements[i]);
            }
            return this;
        }

        public bool IsSubset(PowerSet<T> set2)
        {
            // возвращает true, если set2 есть
            // подмножество текущего множества,
            // иначе false
            for (int i = 0; i < set2.elements.Count; i++)
            {
                if (!elements.Contains(set2.elements[i])) return false;
            }
            return true;
        }
    }
}