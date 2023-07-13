namespace TestTask10;
using AlgorithmsDataStructures;
public class UnitTest1
{
    [Fact]
    public void CreatePowerSet()
    {
        PowerSet<string> powerSet = new PowerSet<string>();
        Assert.Equal(0, powerSet.Size());
    }

    [Fact]
    public void PowerSet_Size()
    {
        PowerSet<string> powerSet = new PowerSet<string>();
        Assert.Equal(0, powerSet.Size());
        powerSet.Put("123");
        Assert.Equal(1, powerSet.Size());
    }

    [Fact]
    public void PowerSet_Put()
    {
        PowerSet<string> powerSet = new PowerSet<string>();
        powerSet.Put("1");
        powerSet.Put("1");
        powerSet.Put("1");
        Assert.Equal(1, powerSet.Size());
        powerSet.Put("2");
        Assert.Equal(2, powerSet.Size());

    }

    [Fact]
    public void PowerSet_Remove()
    {
        PowerSet<string> powerSet = new PowerSet<string>();
        powerSet.Put("1");
        powerSet.Put("1");
        powerSet.Put("1");
        Assert.True(powerSet.Remove("1"));
        Assert.Equal(0, powerSet.Size());

        powerSet.Put("1");
        powerSet.Put("2");
        powerSet.Put("3");
        powerSet.Put("1");
        powerSet.Put("2");
        powerSet.Put("3");
        Assert.Equal(3, powerSet.Size());

        Assert.True(powerSet.Remove("3"));
        Assert.True(powerSet.Remove("2"));
        Assert.True(powerSet.Remove("1"));
        Assert.Equal(0, powerSet.Size());

        Assert.False(powerSet.Remove("3"));
        Assert.False(powerSet.Remove("2"));
        Assert.False(powerSet.Remove("1"));
        Assert.Equal(0, powerSet.Size());
    }

    [Fact]
    public void PowerSet_Get()
    {
        PowerSet<string> powerSet = new PowerSet<string>();
        powerSet.Put("1");
        powerSet.Put("1");
        powerSet.Put("1");
        Assert.True(powerSet.Get("1"));
        Assert.False(powerSet.Get("0"));

        powerSet.Put("1");
        powerSet.Put("2");
        powerSet.Put("3");
        powerSet.Put("1");
        powerSet.Put("2");
        powerSet.Put("3");
        Assert.True(powerSet.Get("1"));
        Assert.True(powerSet.Get("2"));
        Assert.True(powerSet.Get("3"));
        Assert.False(powerSet.Get("4"));
    }

    [Fact]
    public void PowerSet_Without_Intersection()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();
        powerSet1.Put("1");
        powerSet1.Put("2");
        powerSet1.Put("3");
        powerSet2.Put("4");
        powerSet2.Put("5");
        powerSet2.Put("6");

        var result = powerSet1.Intersection(powerSet2);
        Assert.Equal(0, result.Size());
    }

    [Fact]
    public void PowerSet_Intersection()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();
        powerSet1.Put("1");
        powerSet1.Put("2");
        powerSet1.Put("3");
        powerSet2.Put("4");
        powerSet2.Put("2");
        powerSet2.Put("3");

        var result = powerSet1.Intersection(powerSet2);
        Assert.Equal(2, result.Size());
    }

    [Fact]
    public void PowerSet_Intersection_empty()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();

        var result = powerSet1.Intersection(powerSet2);
        Assert.Equal(0, result.Size());
    }

    [Fact]
    public void PowerSet_Union_empty()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();

        var result = powerSet1.Union(powerSet2);
        Assert.Equal(0, result.Size());
    }

    [Fact]
    public void PowerSet_Union()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();
        powerSet1.Put("1");
        powerSet1.Put("2");
        powerSet1.Put("3");
        powerSet2.Put("4");
        powerSet2.Put("5");
        powerSet2.Put("6");

        var result = powerSet1.Union(powerSet2);
        Assert.Equal(6, result.Size());
    }

    [Fact]
    public void PowerSet_Union_with_similar_number()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();

        powerSet1.Put("1");
        powerSet1.Put("2");
        powerSet1.Put("3");

        powerSet2.Put("1");
        powerSet2.Put("3");
        powerSet2.Put("5");

        var result = powerSet1.Union(powerSet2);
        Assert.Equal(4, result.Size());
    }

    [Fact]
    public void PowerSet_Difference_empty()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();

        var result = powerSet1.Difference(powerSet2);
        Assert.Equal(0, result.Size());
    }

    [Fact]
    public void PowerSet_Difference()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();

        powerSet1.Put("1");
        powerSet1.Put("2");
        powerSet1.Put("3");

        powerSet2.Put("3");
        powerSet2.Put("5");

        var result = powerSet1.Difference(powerSet2);
        Assert.Equal(2, result.Size());
    }

    [Fact]
    public void PowerSet_IsSubset_true()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();

        powerSet1.Put("1");
        powerSet1.Put("2");
        powerSet1.Put("3");

        powerSet2.Put("1");
        powerSet2.Put("3");

        var result = powerSet1.IsSubset(powerSet2);
        Assert.True(result);
    }

    [Fact]
    public void PowerSet_IsSubset_false()
    {
        PowerSet<string> powerSet1 = new PowerSet<string>();
        PowerSet<string> powerSet2 = new PowerSet<string>();

        powerSet1.Put("1");
        powerSet1.Put("2");
        powerSet1.Put("3");

        powerSet2.Put("3");
        powerSet2.Put("6");

        var result = powerSet1.IsSubset(powerSet2);
        Assert.False(result);
    }
}