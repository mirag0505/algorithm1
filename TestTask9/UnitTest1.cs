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
        var result = nativeDictionary.IsKey("hellow");
        Assert.True(result);
        Assert.Equal(4, nativeDictionary.Get("hellow"));
        var result1 = nativeDictionary.IsKey("world");
        Assert.True(result1);
        Assert.Equal(3, nativeDictionary.Get("world"));
        var result2 = nativeDictionary.IsKey("ololol");
        Assert.False(result2);
        Assert.Null(nativeDictionary.Get("ololol"));
    }
}