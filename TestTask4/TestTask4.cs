namespace TestTask4;

using AlgorithmsDataStructures;

public class TestTask4
{
    [Fact]
    public void Test_create_stack()
    {
        var stack = new Stack<int>();

        Assert.Equal(0, stack.Size());
        Assert.Equal(default, stack.Peek());

        var stackObjects = new Stack<object>();

        Assert.Equal(0, stackObjects.Size());
        Assert.Equal(default, stackObjects.Peek());
    }

    [Fact]
    public void Size()
    {
        var stack = new Stack<int>();
        Assert.Equal(0, stack.Size());

        stack.Push(1);

        Assert.Equal(1, stack.Size());
        Assert.Equal(1, stack.Peek());

        var stackObjects = new Stack<object>();

        Assert.Equal(0, stackObjects.Size());
        Assert.Equal(default, stackObjects.Peek());

        stackObjects.Push(1);

        Assert.Equal(1, stackObjects.Size());
        Assert.Equal(1, stackObjects.Peek());

        stackObjects.Push("2");

        Assert.Equal(2, stackObjects.Size());
        Assert.Equal("2", stackObjects.Peek());

        stackObjects.Push(3.12);

        Assert.Equal(3, stackObjects.Size());
        Assert.Equal(3.12, stackObjects.Peek());
    }

    [Fact]
    public void Pop_with_empty_stack()
    {
        var stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);

        Assert.Equal(2, stack.Size());
        Assert.Equal(2, stack.Peek());

        Assert.Equal(2, stack.Pop());
        Assert.Equal(1, stack.Pop());
        Assert.Equal(default, stack.Pop());

        var stackObjects = new Stack<object>();

        Assert.Equal(0, stackObjects.Size());
        Assert.Equal(default, stackObjects.Peek());

        stackObjects.Push(1);
        stackObjects.Push("2");
        stackObjects.Push(3.123);

        Assert.Equal(3.123, stackObjects.Pop());
        Assert.Equal("2", stackObjects.Pop());
        Assert.Equal(1, stackObjects.Pop());
        Assert.Equal(default, stackObjects.Pop());
    }

    [Fact]
    public void Pop_empty()
    {
        var stack = new Stack<int>();

        Assert.Equal(default, stack.Pop());
        Assert.Equal(default, stack.Pop());

        var stackObjects = new Stack<object>();

        Assert.Equal(default, stackObjects.Pop());
        Assert.Equal(default, stackObjects.Pop());
    }

    [Fact]
    public void Push()
    {
        var stack = new Stack<string>();

        Assert.Equal(0, stack.Size());
        Assert.Equal(default, stack.Peek());

        stack.Push("a");

        Assert.Equal(1, stack.Size());
        Assert.Equal("a", stack.Peek());

        stack.Push("b");

        Assert.Equal(2, stack.Size());
        Assert.Equal("b", stack.Peek());


        var stackInt = new Stack<int>();

        Assert.Equal(0, stackInt.Size());
        Assert.Equal(default, stackInt.Peek());

        stackInt.Push(1);

        Assert.Equal(1, stackInt.Size());
        Assert.Equal(1, stackInt.Peek());

        stackInt.Push(2);

        Assert.Equal(2, stackInt.Size());
        Assert.Equal(2, stackInt.Peek());

        var stackObjects = new Stack<object>();

        Assert.Equal(0, stackObjects.Size());
        Assert.Equal(default, stackObjects.Peek());

        stackObjects.Push(1);
        stackObjects.Push("2");
        stackObjects.Push(3.123);

        Assert.Equal(3.123, stackObjects.Pop());
        Assert.Equal("2", stackObjects.Pop());
        Assert.Equal(1, stackObjects.Pop());
        Assert.Equal(default, stackObjects.Pop());
    }

    [Fact]
    public void Peek()
    {
        var stack = new Stack<string>();

        Assert.Equal(0, stack.Size());
        Assert.Equal(default, stack.Peek());

        stack.Push("a");
        Assert.Equal(1, stack.Size());
        Assert.Equal("a", stack.Peek());


        var stackInt = new Stack<int>();

        Assert.Equal(0, stackInt.Size());
        Assert.Equal(default, stackInt.Peek());

        stackInt.Push(1);
        Assert.Equal(1, stackInt.Size());
        Assert.Equal(1, stackInt.Peek());

        var stackObjects = new Stack<object>();

        Assert.Equal(0, stackObjects.Size());
        Assert.Equal(default, stackObjects.Peek());

        stackObjects.Push(1);
        Assert.Equal(1, stackObjects.Pop());

        stackObjects.Push("2");
        Assert.Equal("2", stackObjects.Pop());

        stackObjects.Push(3.123);
        Assert.Equal(3.123, stackObjects.Pop());


        Assert.Equal(default, stackObjects.Pop());
    }

    public static bool IsBalansed(string str)
    {
        if (str == null) return false;
        if (str.Length % 2 != 0) return false;

        var stack = new AlgorithmsDataStructures.Stack<char>();
        char[] items = str.ToCharArray();

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == '(')
            {
                stack.Push(items[i]);
                continue;
            }

            if (items[i] == ')')
            {

                var popedValue = stack.Pop();

                if (popedValue == items[i] || popedValue == '\0')
                {
                    return false;
                }
            }

        }
        return true;
    }

    [Fact]
    public void Test_IsBalansed_function()
    {
        Assert.False(IsBalansed(null));

        Assert.True(IsBalansed("(()((())()))"));
        Assert.True(IsBalansed("(()()(()"));

        Assert.False(IsBalansed("())("));
        Assert.False(IsBalansed("))(("));
        Assert.False(IsBalansed("((())"));
    }
}