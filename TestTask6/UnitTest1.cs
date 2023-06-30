using AlgorithmsDataStructures;
using IsPalindrom;

namespace TestTask6;

public class UnitTest1
{
    [Fact]
    public void TestCreateDeque()
    {
        Deque<int> deque = new Deque<int>();
        Assert.True(deque is not null);
        Assert.Equal(0, deque.Size());
    }

    [Fact]
    public void TestAddFront()
    {
        var deque = new Deque<int>();

        deque.AddFront(1);
        Assert.Equal(1, deque.Size());

        deque.AddFront(2);
        Assert.Equal(2, deque.Size());
    }

    [Fact]
    public void TestAddTail()
    {
        var deque = new Deque<int>();

        deque.AddTail(1);
        Assert.Equal(1, deque.Size());

        deque.AddTail(2);
        Assert.Equal(2, deque.Size());
    }

    [Fact]
    public void RemoveFront()
    {
        var deque = new Deque<int>();

        deque.AddFront(2);
        Assert.Equal(1, deque.Size());

        var result1 = deque.RemoveFront();

        Assert.Equal(2, result1);
        Assert.Equal(0, deque.Size());

        deque.AddFront(3);
        deque.AddFront(4);
        Assert.Equal(2, deque.Size());
        var result2 = deque.RemoveFront();
        var result3 = deque.RemoveFront();

        Assert.Equal(4, result2);
        Assert.Equal(3, result3);

        var result4 = deque.RemoveFront();
        Assert.Equal(0, result4);

        var deque2 = new Deque<string>();
        var result5 = deque2.RemoveFront();
        Assert.Null(result5);
    }

    [Fact]
    public void RemoveTail()
    {
        var deque = new Deque<int>();

        deque.AddFront(2);
        Assert.Equal(1, deque.Size());

        var result1 = deque.RemoveTail();

        Assert.Equal(2, result1);
        Assert.Equal(0, deque.Size());

        deque.AddFront(3);
        deque.AddFront(4);
        Assert.Equal(2, deque.Size());
        var result2 = deque.RemoveTail();
        var result3 = deque.RemoveTail();

        Assert.Equal(3, result2);
        Assert.Equal(4, result3);

        var result4 = deque.RemoveTail();
        Assert.Equal(0, result4);

        var deque1 = new Deque<string>();
        var result5 = deque1.RemoveTail();
        Assert.Null(result5);
    }

    [Fact]
    public void Size()
    {
        Deque<int> deque = new Deque<int>();

        deque.AddFront(1);
        Assert.Equal(1, deque.Size());

        deque.AddTail(2);
        Assert.Equal(2, deque.Size());
    }

    [Fact]
    public void IsPalindromTest()
    {
        Assert.False(IsPalindromClass.IsPalindrom("world"));
        Assert.False(IsPalindromClass.IsPalindrom("OpenAI"));
        Assert.False(IsPalindromClass.IsPalindrom("ChatGPT"));
        Assert.False(IsPalindromClass.IsPalindrom("example"));
        Assert.False(IsPalindromClass.IsPalindrom(""));

        Assert.True(IsPalindromClass.IsPalindrom("madam"));
        Assert.True(IsPalindromClass.IsPalindrom("maam"));
        Assert.True(IsPalindromClass.IsPalindrom("racecar"));
        Assert.True(IsPalindromClass.IsPalindrom("wasitacaroracatisaw"));
    }
}