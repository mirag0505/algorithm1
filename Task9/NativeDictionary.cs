using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures
{

    public class NativeDictionary<T>
    {
        public int size;
        public string[] slots;
        public T[] values;

        public NativeDictionary(int sz)
        {
            size = sz;
            slots = new string[size];
            values = new T[size];
        }
        static int GetByteSum(byte[] bytes)
        {
            int sum = 0;
            foreach (byte b in bytes)
            {
                sum += b;
            }
            return sum;
        }
        public int HashFun(string key)
        {
            // всегда возвращает корректный индекс слота
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            int sum = GetByteSum(bytes);
            return sum % size;
        }

        public bool IsKey(string key)
        {
            // возвращает true если ключ имеется,
            // иначе false
            int indexFindedSlot = HashFun(key);
            return slots[indexFindedSlot] != null;
        }

        public void Put(string key, T value)
        {
            // гарантированно записываем 
            // значение value по ключу key
            int indexFindedSlot = HashFun(key);
            slots[indexFindedSlot] = key;
            values[indexFindedSlot] = value;
        }

        public T Get(string key)
        {
            // возвращает value для key, 
            // или null если ключ не найден
            int indexFindedSlot = HashFun(key);
            if (IsKey(key)) return values[indexFindedSlot];

            return default(T);
        }
    }
}