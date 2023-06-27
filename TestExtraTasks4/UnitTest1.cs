using ExtraFunction4;

namespace TestExtraTasks4;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var result = PostfixNotation.PostfixNotationExecuter("1 2 + 3 * =");
        Assert.Equal("9", result);
    }

    [Fact]
    public void Test2()
    {
        var result = PostfixNotation.PostfixNotationExecuter("8 2 + 5 * 9 + =");
        Assert.Equal("59", result);
    }

    [Fact]
    public void Test3_subtracting()
    {
        var result = PostfixNotation.PostfixNotationExecuter("10 2 - =");
        Assert.Equal("8", result);
    }

    [Fact]
    public void Test3_division()
    {
        var result = PostfixNotation.PostfixNotationExecuter("10 2 / =");
        Assert.Equal("5", result);
    }

    [Fact]
    public void Test3_int()
    {
        var result = PostfixNotation.PostfixNotationExecuter("8 2 + 4 - 3 / =");
        Assert.Equal("2", result);
    }

    [Fact]
    public void Test4_int()
    {
        var result = PostfixNotation.PostfixNotationExecuter("8 3 - 5 / 3 + =");
        Assert.Equal("4", result);
    }

    [Fact]
    public void Test4_float()
    {
        var result = PostfixNotation.PostfixNotationExecuter("8 3 / =");
        Assert.Equal("2,6666667", result);
    }

    [Fact]
    public void Test4_negativ()
    {
        var result = PostfixNotation.PostfixNotationExecuter("8 10 - =");
        Assert.Equal("-2", result);
    }
}