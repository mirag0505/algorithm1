namespace TestTask8;
using AlgorithmsDataStructures;

public class UnitTest1
{
    [Fact]
    public void CreateHashTable()
    {
        HashTable hashTable = new HashTable(17, 2);
        Assert.Equal(hashTable.size, 17);
        Assert.Equal(hashTable.step, 2);
        Assert.Equal(hashTable.slots.Length, 17);
    }

    [Fact]
    public void HashFun()
    {
        HashTable hashTable = new HashTable(17, 2);
        var result = hashTable.HashFun("hellow");
        Assert.Equal(5, result);
        var result1 = hashTable.HashFun("world");
        Assert.Equal(8, result1);
    }

    [Fact]
    public void TestPut()
    {
        HashTable hashTable = new HashTable(5, 1);
        var result = hashTable.Put("a");
        var result1 = hashTable.Put("b");
        var result2 = hashTable.Put("c");
        var result3 = hashTable.Put("d");
        var result4 = hashTable.Put("e");

        Assert.Equal(2, result);
        Assert.Equal(3, result1);
        Assert.Equal(4, result2);
        Assert.Equal(0, result3);
        Assert.Equal(1, result4);

        var result5 = hashTable.Put("a");
        var result6 = hashTable.Put("e");
        var result7 = hashTable.Put("f");
        Assert.Equal(-1, result5);
        Assert.Equal(-1, result6);
        Assert.Equal(-1, result7);


        HashTable hashTable2 = new HashTable(5, 1);
        var result21 = hashTable2.Put("a");
        var result22 = hashTable2.Put("a");
        var result23 = hashTable2.Put("a");
        var result24 = hashTable2.Put("a");
        var result25 = hashTable2.Put("a");

        var result26 = hashTable2.Put("a");
        var result27 = hashTable2.Put("a");



        Assert.Equal(2, result21);
        Assert.Equal(3, result22);
        Assert.Equal(4, result23);
        Assert.Equal(0, result24);
        Assert.Equal(1, result25);

        Assert.Equal(-1, result26);
        Assert.Equal(-1, result27);
    }

    [Fact]
    public void TestFind()
    {
        HashTable hashTable = new HashTable(5, 1);
        var result = hashTable.Put("a");
        var result1 = hashTable.Put("b");
        var result2 = hashTable.Put("c");
        var result3 = hashTable.Put("d");
        var result4 = hashTable.Put("e");

        Assert.Equal(result, hashTable.Find("a"));
        Assert.Equal(result1, hashTable.Find("b"));
        Assert.Equal(result2, hashTable.Find("c"));
        Assert.Equal(result3, hashTable.Find("d"));
        Assert.Equal(result4, hashTable.Find("e"));

        Assert.Equal(-1, hashTable.Find("g"));
        Assert.Equal(-1, hashTable.Find("h"));
    }
}