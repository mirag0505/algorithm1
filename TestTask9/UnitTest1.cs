using AlgorithmsDataStructures;

namespace TestTask9;

public class UnitTest1
{
    [Fact]
    public void CreateHashTable()
    {
        NativeDictionary<object> nativeDictionary = new NativeDictionary<object>(17);
        Assert.Equal(nativeDictionary.size, 17);
        Assert.Equal(nativeDictionary.slots.Length, 17);
        Assert.Equal(nativeDictionary.values.Length, 17);
    }

    [Fact]
    public void HashFun()
    {
        NativeDictionary<object> nativeDictionary = new NativeDictionary<object>(17);
        var result = nativeDictionary.HashFun("hellow");
        Assert.Equal(5, result);
        var result1 = nativeDictionary.HashFun("world");
        Assert.Equal(8, result1);
    }

    [Fact]
    public void Put()
    {
        NativeDictionary<object> nativeDictionary = new NativeDictionary<object>(17);
        nativeDictionary.Put("hellow", 4);
        nativeDictionary.Put("world", 3);
        Assert.True(nativeDictionary.IsKey("hellow"));
        Assert.Equal(4, nativeDictionary.Get("hellow"));
        Assert.True(nativeDictionary.IsKey("world"));
        Assert.Equal(3, nativeDictionary.Get("world"));
        Assert.False(nativeDictionary.IsKey("ololol"));
        Assert.Null(nativeDictionary.Get("ololol"));
    }
}