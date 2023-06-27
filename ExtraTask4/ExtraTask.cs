using System;

namespace ExtraFunction4
{
    public class PostfixNotation
    {
        public static string? PostfixNotationExecuter(string str)
        {
            Stack<string> stack1 = new Stack<string>();
            Stack<float> stack2 = new Stack<float>();

            Dictionary<string, Func<float, float, float>> operations = new Dictionary<string, Func<float, float, float>>
            {
                { "+", (a, b) => a + b },
                { "*", (a, b) => a * b },
                { "/", (a, b) => b / a },
                { "-", (a, b) => b - a },
            };

            string[] words = str.Split(" ");

            for (int i = words.Length - 1; i >= 0; i--)
            {
                stack1.Push(words[i]);
            }

            while (stack1.Count > 0)
            {
                var value = stack1.Pop();

                bool isNumber = float.TryParse(value, out float number);
                if (isNumber)
                {
                    stack2.Push(number);
                    continue;
                }

                if (operations.ContainsKey(value) && stack2.Count <= 2)
                {
                    var first = stack2.Pop();
                    var second = stack2.Pop();

                    float result = operations[value](first, second);
                    stack2.Push(result);
                    continue;
                }

                if (value == "=")
                {
                    return string.Join(", ", stack2.Reverse().ToArray());
                }
            }

            return null;
        }
    }
}