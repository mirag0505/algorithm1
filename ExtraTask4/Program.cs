﻿using ExtraFunction4;

class Program
{
    static void Main(string[] args)
    {
        var result = PostfixNotation.PostfixNotationExecuter("10 2 - =");
        Console.Write(result);
    }
}