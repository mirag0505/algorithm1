using AlgorithmsDataStructures;

class Program
{
    static void Main(string[] args)
    {
        HashTable hashTable = new HashTable(5, 1);
        var result = hashTable.Put("a");
        var result1 = hashTable.Put("b");
        var result2 = hashTable.Put("c");
        var result3 = hashTable.Put("d");
        var result4 = hashTable.Put("e");
        var result5 = hashTable.Put("a");
    }
}