using System;

// Operators
class Program
{

    static void Main(string[] args)
    {

        int a = 2;
        int b = 5;

        Mathematics mathematics = new Mathematics();

        var c = mathematics.Add(a, b);

        Console.WriteLine($"c = {c}");
    }
}