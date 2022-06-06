// Language Integrated Query:linq
using System;
using System.Linq;

class Linq
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    // public int[] LearnLinq()=> numbers.Where(number => number % 2 == 1).ToArray();
    public void LearnLinq()
    {
        var oddNumbers = numbers.Where(number => number % 2 == 1);
        var multipleOfThree = numbers.Where(number => number % 3 == 0);
        var squares = numbers.Select(n => n*n);
        var oddSquares = numbers.Where(number => number % 2 == 1)
                                .Select(n => n*n);
        Console.WriteLine($"The odd numbers are");
        foreach (var item in oddNumbers)
        Console.Write(item + " ");
        Console.WriteLine();

        Console.WriteLine($"The multipleOfThree numbers are");
        foreach (var item1 in multipleOfThree)
        Console.Write(item1 + " ");
        Console.WriteLine();

        Console.WriteLine($"The square of each numbers are");
        foreach (var item2 in squares)
        Console.Write(item2 + " ");
        Console.WriteLine();

        Console.WriteLine($"The square of each odd numbers are");
        foreach (var item3 in oddSquares)
        Console.Write(item3 + " ");

    }
}