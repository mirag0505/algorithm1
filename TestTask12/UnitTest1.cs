namespace TestTask12;
using AlgorithmsDataStructures;
public class UnitTestNativeCache
{
    [Fact]
    public void Create_NativeCache()
    {
        NativeCache<int> cache = new NativeCache<int>(3);
        Assert.Equal(3, cache.slots.Length);
        Assert.Equal(3, cache.values.Length);
        Assert.Equal(3, cache.hits.Length);
        Assert.Equal(3, cache.size);
    }

    [Fact]
    public void NativeCache_Get()
    {
        NativeCache<int> cache = new NativeCache<int>(3);
        cache.Put("first", 1);
        Assert.Equal("1,0,0", string.Join(",", cache.values));
        Assert.Equal("first,,", string.Join(",", cache.slots));
        Assert.Equal("0,0,0", string.Join(",", cache.hits));
        Assert.Equal(1, cache.Get("first"));
        Assert.Equal("1,0,0", string.Join(",", cache.hits));
        Assert.Equal(1, cache.Get("first"));
        Assert.Equal("2,0,0", string.Join(",", cache.hits));

        cache.Put("second", 2);
        Assert.Equal("1,2,0", string.Join(",", cache.values));
        Assert.Equal("first,second,", string.Join(",", cache.slots));
        Assert.Equal("2,0,0", string.Join(",", cache.hits));
        Assert.Equal(1, cache.Get("first"));
        Assert.Equal("3,0,0", string.Join(",", cache.hits));
        Assert.Equal(1, cache.Get("first"));
        Assert.Equal("4,0,0", string.Join(",", cache.hits));
    }

    [Fact]
    public void NativeCache_()
    {
        NativeCache<int> cache = new NativeCache<int>(3);
        cache.Put("first", 1);
        cache.Put("first", 2);
        cache.Put("first", 3);
        cache.Put("first", 5);
        Assert.Equal("5,2,3", string.Join(",", cache.values));
        Assert.Equal("first,first,first", string.Join(",", cache.slots));
        Assert.Equal("0,0,0", string.Join(",", cache.hits));

        NativeCache<int> cache1 = new NativeCache<int>(3);
        cache1.Put("first", 1);
        cache1.Put("second", 2);
        cache1.Put("thirst", 3);

        Assert.Equal(1, cache1.Get("first"));
        Assert.Equal(1, cache1.Get("first"));

        Assert.Equal(2, cache1.Get("second"));

        Assert.Equal(0, cache1.Get("fourth"));
        Assert.Equal(0, cache1.Get("fourth"));

        Assert.Equal("2,1,0", string.Join(",", cache1.hits));

        cache1.Put("second", 5);
        Assert.Equal("5,2,3", string.Join(",", cache1.values));
        Assert.Equal("second,second,thirst", string.Join(",", cache1.slots));
    }
}