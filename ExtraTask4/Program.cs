using ExtraFunction4;

class Program
{
    static void Main(string[] args)
    {
        var result = PostfixNotation.PostfixNotationExecuter("1 2 + 3 * =");
        Console.Write(result);
    }
}