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
}