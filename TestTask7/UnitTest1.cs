namespace TestTask7;

using AlgorithmsDataStructures;

public class UnitTestTask7
{
    [Fact]
    public void Test1()
    {
        var orderedList = new OrderedList<int>(true);
        Assert.True(orderedList is not null);
        Assert.Equal(0, orderedList.Count());
    }

    [Fact]
    public void TestCount__ascending_true()
    {
        var orderedList = new OrderedList<int>(true);
        Assert.Equal(0, orderedList.Count());

        orderedList.Add(1);
        Assert.Equal(1, orderedList.Count());
    }

    [Fact]
    public void TestFind()
    {
        var orderedList = new OrderedList<int>(true);
        Assert.Null(orderedList.Find(4));

        orderedList.Add(1);
        Assert.Equal(orderedList.head, orderedList.Find(1));
        Assert.Equal(1, orderedList.Find(1).value);

        orderedList.Add(2);
        Assert.Equal(2, orderedList.Find(2).value);

        orderedList.Add(3);
        Assert.Equal(3, orderedList.Find(3).value);
    }

    [Fact]
    public void TestFindSoonExit()
    {
        var orderedList = new OrderedList<int>(true);

        orderedList.Add(2);
        orderedList.Add(3);
        orderedList.Add(4);

        Assert.Null(orderedList.Find(1));
        Assert.Null(orderedList.Find(5));


        var orderedList2 = new OrderedList<int>(false);

        orderedList2.Add(2);
        orderedList2.Add(3);
        orderedList2.Add(4);

        Assert.Null(orderedList2.Find(1));
        Assert.Null(orderedList2.Find(5));
    }

    [Fact]
    public void TestAdd_one_element__ascending_true()
    {
        var orderedList = new OrderedList<int>(true);

        orderedList.Add(1);

        Assert.Equal("1", orderedList.GetStringListsValue());
        Assert.Equal(1, orderedList.head.value);
        Assert.Equal(1, orderedList.tail.value);

        var orderedList2 = new OrderedList<string>(true);
        orderedList2.Add("abc");

        Assert.Equal("abc", orderedList2.GetStringListsValue());
        Assert.Equal("abc", orderedList2.head.value);
        Assert.Equal("abc", orderedList2.tail.value);
    }

    [Fact]
    public void TestAdd_two_elements()
    {
        var orderedList = new OrderedList<int>(true);

        orderedList.Add(1);
        orderedList.Add(2);

        Assert.Equal("1,2", orderedList.GetStringListsValue());
        Assert.Equal(1, orderedList.head.value);
        Assert.Equal(2, orderedList.tail.value);

        var orderedList2 = new OrderedList<int>(true);

        orderedList2.Add(2);
        orderedList2.Add(1);

        Assert.Equal("1,2", orderedList2.GetStringListsValue());
        Assert.Equal(1, orderedList2.head.value);
        Assert.Equal(2, orderedList2.tail.value);

        var orderedList3 = new OrderedList<string>(true);
        orderedList3.Add("a");
        orderedList3.Add("b");

        Assert.Equal("a,b", orderedList3.GetStringListsValue());
        Assert.Equal("a", orderedList3.head.value);
        Assert.Equal("b", orderedList3.tail.value);

        var orderedList4 = new OrderedList<string>(true);
        orderedList4.Add("b");
        orderedList4.Add("a");

        Assert.Equal("a,b", orderedList4.GetStringListsValue());
        Assert.Equal("a", orderedList4.head.value);
        Assert.Equal("b", orderedList4.tail.value);
    }

    [Fact]
    public void TestAdd_three_elements_didgital()
    {
        var orderedList = new OrderedList<int>(true);

        orderedList.Add(1);
        orderedList.Add(2);
        orderedList.Add(3);

        Assert.Equal("1,2,3", orderedList.GetStringListsValue());
        Assert.Equal(1, orderedList.head.value);
        Assert.Equal(3, orderedList.tail.value);

        var orderedList2 = new OrderedList<int>(true);

        orderedList2.Add(3);
        orderedList2.Add(2);
        orderedList2.Add(1);

        Assert.Equal("1,2,3", orderedList2.GetStringListsValue());
        Assert.Equal(1, orderedList2.head.value);
        Assert.Equal(3, orderedList2.tail.value);

        var orderedList3 = new OrderedList<int>(true);

        orderedList3.Add(2);
        orderedList3.Add(3);
        orderedList3.Add(1);

        Assert.Equal("1,2,3", orderedList3.GetStringListsValue());
        Assert.Equal(1, orderedList3.head.value);
        Assert.Equal(3, orderedList3.tail.value);

        var orderedList4 = new OrderedList<int>(true);

        orderedList4.Add(2);
        orderedList4.Add(3);
        orderedList4.Add(1);

        Assert.Equal("1,2,3", orderedList4.GetStringListsValue());
        Assert.Equal(1, orderedList4.head.value);
        Assert.Equal(3, orderedList4.tail.value);

        var orderedList5 = new OrderedList<int>(true);

        orderedList5.Add(1);
        orderedList5.Add(3);
        orderedList5.Add(2);

        Assert.Equal("1,2,3", orderedList5.GetStringListsValue());
        Assert.Equal(1, orderedList5.head.value);
        Assert.Equal(3, orderedList5.tail.value);

        var orderedList6 = new OrderedList<int>(true);

        orderedList6.Add(1);
        orderedList6.Add(1);
        orderedList6.Add(3);
        orderedList6.Add(2);

        Assert.Equal("1,1,2,3", orderedList6.GetStringListsValue());
        Assert.Equal(1, orderedList6.head.value);
        Assert.Equal(3, orderedList6.tail.value);

        var orderedList7 = new OrderedList<int>(true);

        orderedList7.Add(1);
        orderedList7.Add(3);
        orderedList7.Add(3);
        orderedList7.Add(2);

        Assert.Equal("1,2,3,3", orderedList7.GetStringListsValue());
        Assert.Equal(1, orderedList7.head.value);
        Assert.Equal(3, orderedList7.tail.value);

        var orderedList8 = new OrderedList<int>(true);

        orderedList8.Add(1);
        orderedList8.Add(2);
        orderedList8.Add(3);
        orderedList8.Add(2);

        Assert.Equal("1,2,2,3", orderedList8.GetStringListsValue());
        Assert.Equal(1, orderedList8.head.value);
        Assert.Equal(3, orderedList8.tail.value);
    }

    [Fact]
    public void TestAdd_three_elements_didgital_ascending_fasle()
    {
        var orderedList = new OrderedList<int>(false);

        orderedList.Add(1);
        orderedList.Add(2);
        orderedList.Add(3);

        Assert.Equal("3,2,1", orderedList.GetStringListsValue());
        Assert.Equal(3, orderedList.head.value);
        Assert.Equal(1, orderedList.tail.value);

        var orderedList2 = new OrderedList<int>(false);

        orderedList2.Add(3);
        orderedList2.Add(2);
        orderedList2.Add(1);

        Assert.Equal("3,2,1", orderedList2.GetStringListsValue());
        Assert.Equal(3, orderedList2.head.value);
        Assert.Equal(1, orderedList2.tail.value);

        var orderedList3 = new OrderedList<int>(false);

        orderedList3.Add(2);
        orderedList3.Add(3);
        orderedList3.Add(1);

        Assert.Equal("3,2,1", orderedList3.GetStringListsValue());
        Assert.Equal(3, orderedList3.head.value);
        Assert.Equal(1, orderedList3.tail.value);

        var orderedList4 = new OrderedList<int>(false);

        orderedList4.Add(2);
        orderedList4.Add(3);
        orderedList4.Add(1);

        Assert.Equal("3,2,1", orderedList4.GetStringListsValue());
        Assert.Equal(3, orderedList4.head.value);
        Assert.Equal(1, orderedList4.tail.value);

        var orderedList5 = new OrderedList<int>(false);

        orderedList5.Add(1);
        orderedList5.Add(3);
        orderedList5.Add(2);

        Assert.Equal("3,2,1", orderedList5.GetStringListsValue());
        Assert.Equal(3, orderedList5.head.value);
        Assert.Equal(1, orderedList5.tail.value);

        var orderedList6 = new OrderedList<int>(false);

        orderedList6.Add(1);
        orderedList6.Add(1);
        orderedList6.Add(3);
        orderedList6.Add(2);

        Assert.Equal("3,2,1,1", orderedList6.GetStringListsValue());
        Assert.Equal(3, orderedList6.head.value);
        Assert.Equal(1, orderedList6.tail.value);

        var orderedList7 = new OrderedList<int>(false);

        orderedList7.Add(1);
        orderedList7.Add(3);
        orderedList7.Add(3);
        orderedList7.Add(2);

        Assert.Equal("3,3,2,1", orderedList7.GetStringListsValue());
        Assert.Equal(3, orderedList7.head.value);
        Assert.Equal(1, orderedList7.tail.value);

        var orderedList8 = new OrderedList<int>(false);

        orderedList8.Add(1);
        orderedList8.Add(2);
        orderedList8.Add(3);
        orderedList8.Add(2);

        Assert.Equal("3,2,2,1", orderedList8.GetStringListsValue());
        Assert.Equal(3, orderedList8.head.value);
        Assert.Equal(1, orderedList8.tail.value);
    }

    [Fact]
    public void TestAdd_three_elements_string()
    {
        var orderedList = new OrderedList<string>(true);

        orderedList.Add("a");
        orderedList.Add("b");
        orderedList.Add("c");

        Assert.Equal("a,b,c", orderedList.GetStringListsValue());
        Assert.Equal("a", orderedList.head.value);
        Assert.Equal("c", orderedList.tail.value);

        var orderedList2 = new OrderedList<string>(true);

        orderedList2.Add("c");
        orderedList2.Add("b");
        orderedList2.Add("a");

        Assert.Equal("a,b,c", orderedList2.GetStringListsValue());
        Assert.Equal("a", orderedList2.head.value);
        Assert.Equal("c", orderedList2.tail.value);

        var orderedList3 = new OrderedList<string>(true);

        orderedList3.Add("b");
        orderedList3.Add("c");
        orderedList3.Add("a");

        Assert.Equal("a,b,c", orderedList3.GetStringListsValue());
        Assert.Equal("a", orderedList3.head.value);
        Assert.Equal("c", orderedList3.tail.value);

        var orderedList4 = new OrderedList<string>(true);

        orderedList4.Add("b");
        orderedList4.Add("c");
        orderedList4.Add("a");

        Assert.Equal("a,b,c", orderedList4.GetStringListsValue());
        Assert.Equal("a", orderedList4.head.value);
        Assert.Equal("c", orderedList4.tail.value);

        var orderedList5 = new OrderedList<string>(true);

        orderedList5.Add("a");
        orderedList5.Add("c");
        orderedList5.Add("b");

        Assert.Equal("a,b,c", orderedList5.GetStringListsValue());
        Assert.Equal("a", orderedList5.head.value);
        Assert.Equal("c", orderedList5.tail.value);
    }

    [Fact]
    public void TestDelete()
    {
        var orderedList = new OrderedList<int>(true);
        Assert.Null(orderedList.Find(4));

        orderedList.Add(1);
        orderedList.Add(2);
        orderedList.Add(3);

        Assert.Equal(orderedList.head, orderedList.Find(1));
        Assert.Equal(1, orderedList.Find(1).value);
        Assert.Equal(2, orderedList.Find(2).value);
        Assert.Equal(3, orderedList.Find(3).value);
        Assert.Equal(orderedList.tail, orderedList.Find(3));

        orderedList.Delete(1);
        Assert.Null(orderedList.Find(1));
        Assert.Equal("2,3", orderedList.GetStringListsValue());

        orderedList.Delete(2);
        Assert.Null(orderedList.Find(2));
        Assert.Equal("3", orderedList.GetStringListsValue());

        orderedList.Delete(3);
        Assert.Null(orderedList.Find(3));
        Assert.Equal("", orderedList.GetStringListsValue());

        var orderedList2 = new OrderedList<int>(false);
        orderedList2.Add(1);
        orderedList2.Add(2);
        orderedList2.Add(2);
        orderedList2.Add(3);
        Assert.Equal("3,2,2,1", orderedList2.GetStringListsValue());

        orderedList2.Delete(2);
        Assert.Equal("3,2,1", orderedList2.GetStringListsValue());
    }

    [Fact]
    public void TestDelete_string()
    {
        var orderedList = new OrderedList<string>(false);
        Assert.Null(orderedList.Find("4"));

        orderedList.Add("1");
        orderedList.Add("3");
        orderedList.Add("2");

        Assert.Equal(orderedList.tail, orderedList.Find("1"));
        Assert.Equal("1", orderedList.Find("1").value);
        Assert.Equal("2", orderedList.Find("2").value);
        Assert.Equal("3", orderedList.Find("3").value);
        Assert.Equal(orderedList.head, orderedList.Find("3"));

        orderedList.Delete("1");
        Assert.Null(orderedList.Find("1"));
        Assert.Equal("3,2", orderedList.GetStringListsValue());

        orderedList.Delete("2");
        Assert.Null(orderedList.Find("2"));
        Assert.Equal("3", orderedList.GetStringListsValue());

        orderedList.Delete("3");
        Assert.Null(orderedList.Find("3"));
        Assert.Equal("", orderedList.GetStringListsValue());

        var orderedList2 = new OrderedList<string>(false);
        orderedList2.Add("1");
        orderedList2.Add("3");
        orderedList2.Add("2");
        orderedList2.Add("4");

        orderedList2.Delete("4");
        Assert.Null(orderedList2.Find("4"));
        Assert.Equal("3,2,1", orderedList2.GetStringListsValue());

        orderedList2.Delete("1");
        Assert.Null(orderedList2.Find("1"));
        Assert.Equal("3,2", orderedList2.GetStringListsValue());

        orderedList2.Delete("3");
        orderedList2.Delete("2");
        Assert.Null(orderedList2.Find("3"));
        Assert.Null(orderedList2.Find("2"));
        Assert.Equal("", orderedList2.GetStringListsValue());


    }
}