namespace Patterns;
using System;
class PatternGen
{
    internal void PatternGenerate()
    {
        for (byte i = 1; i < 7; i++)
        {
            for (byte j = 1; j < i + 1; j++)
            {
                Console.Write(j);

            }
            Console.WriteLine();
        Console.WriteLine();
        }
    }
    internal void PatternGenerate1()
    {
        for (byte i = 1; i < 7; i++)
        {
            for (byte j = 1; j < i + 1; j++)
            {
                Console.Write("#");

            }
            Console.WriteLine();
        Console.WriteLine();

        }
    }
    internal void PatternGenerate2()
    {
        for (byte i = 1; i <= 9; i+=2)
        {
            for (byte j = i; j <= 9; j++)
            {
                Console.Write(" ");
            }
            for (byte k = 1; k < i+1; k++)
            {
                Console.Write(" "+"#");
            }
            Console.WriteLine();
        Console.WriteLine();
        }
    }
}

