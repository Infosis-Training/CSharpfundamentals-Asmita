
using System;
using System.Collections.Generic;

namespace Collect;
class Collection
{
    internal void LearnArrays()
    {
        // 1D
        byte[] age = new byte[20];
        age[0] = 23;
        age[1] = 33;

        float[] numbers = { 14, 24, 34 };

        // 2D multi
        decimal[,] mat = new decimal[3, 4];
        mat[0, 0] = 10;
        mat[0, 1] = 10;
        mat[0, 2] = 10;
        mat[0, 3] = 10;

        double[,] table = { { 2, 3 }, { 4, 5 } };

        // jagged array
        string[][] semNames = new string[3][];
        string[] firstSemNames = { "Rama", "Ram" };
        string[] secondSemNames = { "Hama", "Ham", "Hamsa" };
        string[] thirdSemNames = { "Raman", "Rami", "Raju", "Ranjan" };

        semNames[0] = firstSemNames;
        semNames[1] = secondSemNames;
        semNames[2] = thirdSemNames;
        Console.WriteLine(semNames[2][3]);
    }
    internal void LearnBuiltInCollections()
    {
        // list
        List<int> numbers = new();
        numbers.Add(35);
        numbers.Add(23);
        numbers.Add(33);
        numbers.Add(45);
        numbers.Remove(45);

        // stack 
        Stack<string> names = new();
        names.Push("AG");
        names.Push("AG");
        names.Pop();

        // queue
        Queue<double> bill = new();
        bill.Enqueue(22.2);
        bill.Enqueue(33.3);
        bill.Dequeue();

        // Dictionary:stores in keyvalue pair(key,value)
        Dictionary<string, byte> data = new();
        try
        {
            data.Add("Asmita", 24);
            data.Add("Asmita", 20);
            data.Add("Asmi", 16);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // or
        Dictionary<string, byte> data1 = new()
        {
            ["Asmita"] = 24,
            ["Asmit"] = 24,
            ["Asmi"] = 24
        };

        foreach (var item in data)
        {
            Console.WriteLine($"{item.Key} is {item.Value} years old");
        }

    }
}