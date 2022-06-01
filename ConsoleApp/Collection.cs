
using System;
namespace Collect;
class Collection
{
    internal void LearnArrays()
    {
        // 1D
        byte[] age = new byte[20];
        age[0] = 23;
        age[1] = 33;

        float[] numbers = {14,24,34};

        // 2D multi
        decimal[,] mat = new decimal[3,4];
        mat[0,0] = 10;
        mat[0,1] = 10;
        mat[0,2] = 10;
        mat[0,3] = 10;

        double[,] table = {{2,3}, {4,5}};

        // jagged array
        string[][] semNames =  new string[3][];
        string[] firstSemNames = {"Rama","Ram"};
        string[] secondSemNames = {"Hama","Ham","Hamsa"};
        string[] thirdSemNames = {"Raman","Rami","Raju","Ranjan"};

        semNames[0] = firstSemNames;
        semNames[1] = secondSemNames;
        semNames[2] = thirdSemNames;
        Console.WriteLine(semNames[2][3]);
    }
}