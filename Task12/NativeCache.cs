using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures
{
    class NativeCache<T>
    {
        public int size;
        public String[] slots;
        public T[] values;
        public int[] hits;//колличество использований
        public int STEP = 1;//колличество использований

        public NativeCache(int sz)
        {
            size = sz;
            slots = new string[size];
            values = new T[size];
            hits = new int[size];
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
        public bool IsKey(string key)
        {
            // возвращает true если ключ имеется,
            // иначе false
            int indexFindedSlot = HashFun(key);
            return slots[indexFindedSlot] == key;
        }

        public int HashFun(string key)
        {
            // всегда возвращает корректный индекс слота
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            int sum = GetByteSum(bytes);
            return sum % size;
        }

        public int SeekSlot(string key)
        {
            int slotIndex = HashFun(key);

            if (slotIndex < 0) return -1;
            if (slots[slotIndex] == null) return slotIndex;

            int i = slotIndex + STEP;
            while (i != slotIndex)
            {
                if (i < size && slots[i] == null) return i;

                if (i >= size) i -= size;
                else i += STEP;
            }

            // находит индекс пустого слота для значения, или -1
            return -1;
        }

        public void Put(string key, T value)
        {


            // int indexFindedSlot1 = SeekSlot(key);
            // if (indexFindedSlot1 > -1)
            // {
            //     slots[indexFindedSlot1] = key;
            //     values[indexFindedSlot1] = value;
            //     hits[indexFindedSlot1] = 0;
            //     return;
            // }

            int indexFindedSlot;

            do
            {
                indexFindedSlot = SeekSlot(key);
                if (indexFindedSlot > -1)
                {
                    slots[indexFindedSlot] = key;
                    values[indexFindedSlot] = value;
                    hits[indexFindedSlot] = 0;
                    return;
                }

                // если все слоты заняты, тогда вытесняем элемент, у которого меньше всего обращений
                int minValueHit = 0;
                int minValueHitIndex = 0;
                for (int i = 0; i < hits.Length; i++)
                {
                    if (minValueHit > hits[i])
                    {
                        minValueHit = hits[i];
                        minValueHitIndex = i;
                    }
                }

                // вытесняем элемент, и на новый круг, чтоб найти это место, через коллизии
                slots[minValueHitIndex] = default;
                values[minValueHitIndex] = default;
                hits[minValueHitIndex] = 0;

            } while (indexFindedSlot == -1);
        }

        public T Get(string key)
        {
            int slotIndex = HashFun(key);

            if (slots[slotIndex] == key)
            {
                hits[slotIndex] = hits[slotIndex] + 1;
                return values[slotIndex];
            }

            int i = slotIndex + STEP;
            while (i != slotIndex)
            {
                if (i < size && slots[i] == key)
                {
                    hits[i] = hits[i] + 1;
                    return values[i];
                }

                if (i >= size) i -= size;
                else i += STEP;
            }

            return default;
        }
    }
}