namespace TestTask5;
using AlgorithmsDataStructures;

public class UnitTest1
{
    [Fact]
    public void TestCreateQueue()
    {
        var queue = new Queue<int>();
        Assert.True(queue is not null);
        Assert.Equal(0, queue.Size());
    }

    [Fact]
    public void TestEnqueue()
    {
        var queue = new Queue<int>();

        queue.Enqueue(1);
        Assert.Equal(1, queue.Size());

        queue.Enqueue(2);
        Assert.Equal(2, queue.Size());
    }

    [Fact]
    public void Dequeue()
    {
        var queue = new Queue<int>();

        queue.Enqueue(2);
        Assert.Equal(1, queue.Size());

        var result1 = queue.Dequeue();

        Assert.Equal(2, result1);
        Assert.Equal(0, queue.Size());

        queue.Enqueue(3);
        queue.Enqueue(4);
        Assert.Equal(2, queue.Size());
        var result2 = queue.Dequeue();
        var result3 = queue.Dequeue();

        Assert.Equal(3, result2);
        Assert.Equal(4, result3);

        var result4 = queue.Dequeue();
        Assert.Equal(0, result4);

        var queue1 = new Queue<string>();
        var result5 = queue1.Dequeue();
        Assert.Null(result5);
    }

    [Fact]
    public void Size()
    {
        var queue = new Queue<int>();

        queue.Enqueue(1);
        Assert.Equal(1, queue.Size());

        queue.Enqueue(2);
        Assert.Equal(2, queue.Size());
    }
}