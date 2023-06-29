using AlgorithmsDataStructures;
namespace IsPalindrom;

public class IsPalindromClass
{
    public static bool IsPalindrom(string str)
    {
        if (str == null) return false;
        if (str.Length == 0) return false;

        Deque<char> deque = new Deque<char>();
        char[] charArray = str.ToCharArray();

        foreach (char item in charArray)
        {
            deque.AddTail(item);
        }

        while (deque.Size() > 1)
        {
            var first = deque.RemoveFront();
            var second = deque.RemoveTail();

            if (first != second) return false; ;
        }

        return true;
    }
}
