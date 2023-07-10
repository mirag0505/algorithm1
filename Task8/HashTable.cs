using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures
{

    public class HashTable
    {
        public int size;
        public int step;
        public string[] slots;

        public HashTable(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new string[size];
            for (int i = 0; i < size; i++) slots[i] = null;
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

        public int HashFun(string value)
        {
            // всегда возвращает корректный индекс слота

            // Мы можем, например, суммировать байты каждой строки, 
            // брать остаток от деления суммы на 128(длину),
            // и таким образом получать уникальный индекс.
            if (value == null) return -1;
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            int sum = GetByteSum(bytes);
            return sum % size;
        }

        public int SeekSlot(string value)
        {
            if (value == null) return -1;
            int slotIndex = HashFun(value);

            if (slotIndex < 0) return -1;
            if (slots[slotIndex] == null) return slotIndex;

            int i = slotIndex + step;
            while (i != slotIndex)
            {
                if (i < size && slots[i] == null) return i;

                if (i >= size) i -= size;
                else i += step;
            }

            // находит индекс пустого слота для значения, или -1
            return -1;
        }

        public int Put(string value)
        {
            // записываем значение по хэш-функции

            // возвращается индекс слота или -1
            // если из-за коллизий элемент не удаётся разместить 
            if (value == null) return -1;
            int indexFindedSlot = SeekSlot(value);
            if (indexFindedSlot > -1) slots[indexFindedSlot] = value;
            return indexFindedSlot;
        }

        public int Find(string value)
        {
            // находит индекс слота со значением, или -1
            if (value == null) return -1;
            int slotIndex = HashFun(value);

            if (slots[slotIndex] == value) return slotIndex;

            int i = slotIndex + step;
            while (i != slotIndex)
            {
                if (i < size && slots[i] == value) return i;

                if (i >= size) i -= size;
                else i += step;
            }

            return -1;
        }
    }

}