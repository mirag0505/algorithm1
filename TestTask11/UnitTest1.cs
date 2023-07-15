namespace TestTask11;
using AlgorithmsDataStructures;
public class UnitTest1
{
    [Fact]
    public void CreateBloomFilter()
    {
        BloomFilter bloomFilter = new BloomFilter(32);
        Assert.Equal(32, bloomFilter.filter_len);
    }

    [Fact]
    public void BloomFilter_Hash1()
    {
        BloomFilter bloomFilter = new BloomFilter(32);
        var result = bloomFilter.Hash1("0123456789");
        Assert.Equal(7, result);
        Assert.Equal("111", Convert.ToString(result, 2));
    }

    [Fact]
    public void BloomFilter_Hash2()
    {
        BloomFilter bloomFilter = new BloomFilter(32);
        var result = bloomFilter.Hash2("0123456789");
        Assert.Equal(9, result);
    }

    [Fact]
    public void BloomFilter_Add()
    {
        BloomFilter bloomFilter = new BloomFilter(32);
        bloomFilter.Add("0123456789");
        Assert.Equal("1010000000", Convert.ToString(bloomFilter.bittest, 2));
    }

    [Fact]
    public void BloomFilter_IsValue()
    {
        BloomFilter bloomFilter = new BloomFilter(32);
        bloomFilter.Add("0123456789");

        Assert.True(bloomFilter.IsValue("0123456789"));
        Assert.False(bloomFilter.IsValue("1234567890"));
        Assert.False(bloomFilter.IsValue("8901234567"));
        Assert.False(bloomFilter.IsValue("9012345678"));
        Assert.False(bloomFilter.IsValue("3645"));
    }
}