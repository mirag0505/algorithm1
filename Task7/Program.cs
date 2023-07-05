using AlgorithmsDataStructures;

class Program
{
    static void Main(string[] args)
    {
        var orderedList = new OrderedList<int>(true);

        orderedList.Add(1);
        orderedList.Add(3);
        orderedList.Add(2);

        string resultString = orderedList.GetStringListsValue();
    }
}