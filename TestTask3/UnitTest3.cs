using AlgorithmsDataStructures;
namespace TestTask3;

public class UnitTest3
{
    [Fact]
    public void Test_create_DynArray()
    {
        var dynaArray = new DynArray<int>();
        Assert.Equal(dynaArray.count, 0);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);
    }

    [Fact]
    public void Test_Append()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);

        Assert.Equal(dynaArray.count, 1);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);
    }

    [Fact]
    public void Test_GetItem()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);
        var result = dynaArray.GetItem(0);

        Assert.Equal(result, 1);
        Assert.Equal(dynaArray.count, 1);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);

        dynaArray.Append(2);
        var result1 = dynaArray.GetItem(1);

        Assert.Equal(result1, 2);
        Assert.Equal(dynaArray.count, 2);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);
    }

    [Fact]
    public void Test_MakeArray_expand()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);
        dynaArray.Append(2);
        dynaArray.Append(3);
        dynaArray.Append(4);
        dynaArray.Append(5);
        dynaArray.Append(6);
        dynaArray.Append(7);
        dynaArray.Append(8);
        dynaArray.Append(9);
        dynaArray.Append(10);
        dynaArray.Append(11);
        dynaArray.Append(12);
        dynaArray.Append(13);
        dynaArray.Append(14);
        dynaArray.Append(15);
        dynaArray.Append(16);

        dynaArray.Append(17);
        var result = dynaArray.GetItem(16);

        Assert.Equal(result, 17);
        Assert.Equal(dynaArray.count, 17);
        Assert.Equal(dynaArray.capacity, 32);
        Assert.Equal(dynaArray.array.Length, 32);
    }

    [Fact]
    public void Test_Insert()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(2);
        dynaArray.Append(3);
        dynaArray.Append(4);
        dynaArray.Insert(1, 0);

        var result1 = dynaArray.GetItem(0);
        var result2 = dynaArray.GetItem(3);

        Assert.Equal(result1, 1);
        Assert.Equal(result2, 4);
        Assert.Equal(dynaArray.count, 4);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);
    }

    [Fact]
    public void Test_Insert_expanded()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);
        dynaArray.Append(2);
        dynaArray.Append(3);
        dynaArray.Append(4);
        dynaArray.Append(5);
        dynaArray.Append(6);
        dynaArray.Append(8);
        dynaArray.Append(9);
        dynaArray.Append(10);
        dynaArray.Append(11);
        dynaArray.Append(12);
        dynaArray.Append(13);
        dynaArray.Append(14);
        dynaArray.Append(15);
        dynaArray.Append(16);
        dynaArray.Append(17);

        dynaArray.Insert(7, 6);

        var result1 = dynaArray.GetItem(0);
        var result2 = dynaArray.GetItem(6);
        var result3 = dynaArray.GetItem(16);

        Assert.Equal(result1, 1);
        Assert.Equal(result2, 7);
        Assert.Equal(result3, 17);
        Assert.Equal(dynaArray.count, 17);
        Assert.Equal(dynaArray.capacity, 32);
        Assert.Equal(dynaArray.array.Length, 32);
    }

    [Fact]
    public void Test_Insert_expanded_to_tail()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);
        dynaArray.Append(2);
        dynaArray.Append(3);
        dynaArray.Append(4);
        dynaArray.Append(5);
        dynaArray.Append(6);
        dynaArray.Append(7);
        dynaArray.Append(8);
        dynaArray.Append(9);
        dynaArray.Append(10);
        dynaArray.Append(11);
        dynaArray.Append(12);
        dynaArray.Append(13);
        dynaArray.Append(14);
        dynaArray.Append(15);
        dynaArray.Append(16);

        dynaArray.Insert(50, 16);

        var result1 = dynaArray.GetItem(0);
        var result2 = dynaArray.GetItem(6);
        var result3 = dynaArray.GetItem(16);

        Assert.Equal(result1, 1);
        Assert.Equal(result2, 7);
        Assert.Equal(result3, 50);
        Assert.Equal(dynaArray.count, 17);
        Assert.Equal(dynaArray.capacity, 32);
        Assert.Equal(dynaArray.array.Length, 32);
    }

    [Fact]
    public void Test_Remove()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);
        dynaArray.Append(2);
        dynaArray.Append(3);

        dynaArray.Remove(0);

        var result1 = dynaArray.GetItem(0);
        var result2 = dynaArray.GetItem(1);

        Assert.Equal(result1, 2);
        Assert.Equal(result2, 3);

        Assert.Equal(dynaArray.count, 2);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);
    }

    [Fact]
    public void Test_Remove_middle()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);
        dynaArray.Append(2);
        dynaArray.Append(3);

        dynaArray.Remove(1);

        var result1 = dynaArray.GetItem(0);
        var result2 = dynaArray.GetItem(1);

        Assert.Equal(result1, 1);
        Assert.Equal(result2, 3);

        Assert.Equal(dynaArray.count, 2);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);
    }

    [Fact]
    public void Test_Remove_end()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);
        dynaArray.Append(2);
        dynaArray.Append(3);

        dynaArray.Remove(2);

        var result1 = dynaArray.GetItem(0);
        var result2 = dynaArray.GetItem(1);

        Assert.Equal(result1, 1);
        Assert.Equal(result2, 2);

        Assert.Equal(dynaArray.count, 2);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);
    }

    [Fact]
    public void Test_Remove_narrow_two_time()
    {
        var dynaArray = new DynArray<int>();
        dynaArray.Append(1);
        dynaArray.Append(2);
        dynaArray.Append(3);
        dynaArray.Append(4);
        dynaArray.Append(5);
        dynaArray.Append(6);
        dynaArray.Append(7);
        dynaArray.Append(8);
        dynaArray.Append(9);
        dynaArray.Append(10);
        dynaArray.Append(11);
        dynaArray.Append(12);
        dynaArray.Append(13);
        dynaArray.Append(14);
        dynaArray.Append(15);
        dynaArray.Append(16);
        dynaArray.Append(17);

        dynaArray.Remove(16);
        dynaArray.Remove(15);

        var result1 = dynaArray.GetItem(0);
        var result2 = dynaArray.GetItem(14);

        Assert.Equal(result1, 1);
        Assert.Equal(result2, 15);

        Assert.Equal(dynaArray.count, 15);
        Assert.Equal(dynaArray.capacity, 21);
        Assert.Equal(dynaArray.array.Length, 21);

        dynaArray.Remove(14);
        dynaArray.Remove(13);
        dynaArray.Remove(12);
        dynaArray.Remove(11);
        dynaArray.Remove(10);
        dynaArray.Remove(9);

        var result3 = dynaArray.GetItem(0);
        var result4 = dynaArray.GetItem(8);

        Assert.Equal(result3, 1);
        Assert.Equal(result4, 9);

        Assert.Equal(dynaArray.count, 9);
        Assert.Equal(dynaArray.capacity, 16);
        Assert.Equal(dynaArray.array.Length, 16);
    }

    [Fact]
    public void Test_GetItem_exeption()
    {
        var dynaArray = new DynArray<int>();
        Assert.Throws<ArgumentOutOfRangeException>(() => dynaArray.GetItem(34));
    }

    [Fact]
    public void Test_Insert_exeption()
    {
        var dynaArray = new DynArray<int>();
        Assert.Throws<ArgumentOutOfRangeException>(() => dynaArray.Insert(1, 34));
    }

    [Fact]
    public void Test_Remove_exeption()
    {
        var dynaArray = new DynArray<int>();
        Assert.Throws<ArgumentOutOfRangeException>(() => dynaArray.Remove(34));
    }

    [Fact]
    public void Test_Remove_exeption_empty_array()
    {
        var dynaArray = new DynArray<int>();
        Assert.Throws<ArgumentOutOfRangeException>(() => dynaArray.Remove(0));
    }
}