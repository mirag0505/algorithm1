using System;

namespace ExtraFunction4
{
    public class PostfixNotation
    {
        public static string? PostfixNotationExecuter(string str)
        {
            Stack<char> stack1 = new Stack<char>();
            Stack<int> stack2 = new Stack<int>();

            Dictionary<string, Func<int, int, int>> operations = new Dictionary<string, Func<int, int, int>>
            {
                { "+", (a, b) => a + b },
                { "*", (a, b) => a * b },
            };

            char[] items = str.ToArray();

            for (int i = items.Length - 1; 0 <= i; i--)
            {
                if (items[i] != ' ') stack1.Push(items[i]);
            }

            while (stack1.Count > 0)
            {
                var value = stack1.Pop();

                bool isNumber = int.TryParse(value.ToString(), out int number);
                if (isNumber)
                {
                    stack2.Push(number);
                    continue;
                }

                if (operations.ContainsKey(value.ToString()) && stack2.Count <= 2)
                {
                    int result = (int)operations[value.ToString()](stack2.Pop(), stack2.Pop());
                    stack2.Push(result);
                }

                if (value == '=')
                {
                    return string.Join(", ", stack2.Reverse().ToArray());
                }
            }

            return null;
        }
    }
}