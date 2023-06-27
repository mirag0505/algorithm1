namespace ExtraFunctions
{
    public class ExtraFunction
    {
        public static bool IsBalansed(string str)
        {
            if (str == null) return false;
            if (str.Length % 2 != 0) return false;

            var stack = new AlgorithmsDataStructures.Stack<char>();
            char[] charArray = str.ToCharArray();

            foreach (char item in charArray)
            {
                if (item == '(')
                {
                    stack.Push(item);
                    continue;
                }

                char popedValue = stack.Pop();
                if (popedValue == item) return false;
            }

            return stack.Size() == 0;
        }
    }

}
