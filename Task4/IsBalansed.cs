using System;
using AlgorithmsDataStructures;

namespace ExtraFunction
{
    public class ExtraFunction
    {
        public static bool IsBalansed(string str)
        {
            if (str == null) return false;
            if (str.Length % 2 != 0) return false;

            var stack = new AlgorithmsDataStructures.Stack<char>();
            char[] items = str.ToCharArray();

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == '(')
                {
                    stack.Push(items[i]);
                    continue;
                }

                var popedValue = stack.Pop();

                if (popedValue == items[i] || popedValue == '\0')
                {
                    return false;
                }

            }
            return true;
        }

    }

}
