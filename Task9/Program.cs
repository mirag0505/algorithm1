using AlgorithmsDataStructures;

class Program
{
    static void Main(string[] args)
    {
        NativeDictionary<object> nativeDictionary = new NativeDictionary<object>(17);
        nativeDictionary.Put("hellow", 4);
        nativeDictionary.Put("world", 3);
        var result = nativeDictionary.IsKey("hellow");
        var result1 = nativeDictionary.IsKey("world");
        var result2 = nativeDictionary.IsKey("ololol");
    }
}