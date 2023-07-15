using System.Collections.Generic;
using System;
using System.IO;
using System.Collections;

namespace AlgorithmsDataStructures
{
    public class BloomFilter
    {
        public int filter_len;
        public int bittest;

        public BloomFilter(int f_len)
        {
            filter_len = f_len;
            // создаём битовый массив длиной f_len ...
            bittest = 0;
        }

        // хэш-функции
        public int Hash1(string str1)
        {
            // 17
            int hashIndex = 0;
            int randomNumber = 17;

            for (int i = 0; i < str1.Length; i++)
            {
                int code = (int)str1[i];
                hashIndex = (hashIndex * randomNumber + code) % filter_len;
            }

            return hashIndex;
            // "надо сделать из этого индекса битовую маску"
        }
        public int Hash2(string str1)
        {
            // 223
            int hashIndex = 0;
            int randomNumber = 223;

            for (int i = 0; i < str1.Length; i++)
            {
                int code = (int)str1[i];
                hashIndex = (hashIndex * randomNumber + code) % filter_len;
            }
            return hashIndex;
        }

        public void Add(string str1)
        {
            // добавляем строку str1 в фильтр
            int index1 = Hash1(str1);
            int index2 = Hash2(str1);

            int mask1 = 0;
            int mask2 = 0;
            mask1 = mask1 | (1 << index1);
            mask2 = mask2 | (1 << index2);

            bittest = bittest | mask1;
            bittest = bittest | mask2;
        }

        public bool IsValue(string str1)
        {
            // проверка, имеется ли строка str1 в фильтре
            int index1 = Hash1(str1);
            int index2 = Hash2(str1);

            int mask1 = 1 << index1;
            int mask2 = 1 << index2;

            bool isInclude = (mask1 & bittest) != 0 && (mask2 & bittest) != 0;

            return isInclude;
        }
    }
}