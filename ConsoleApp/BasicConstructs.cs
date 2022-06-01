using System;
class Basics
{
    // public static void Main1()
    // {
    //     LearnLoops();
    //     // LearnConditionals(55);
    //     // LearnConditionals(80);
    // }
    void LearnConditionals(byte x)
    {
        if (x < 50)
        {
            Console.WriteLine(x + " is less than 50");
        }
        else if (x < 70)
        {
            Console.WriteLine(x + " is greater than 50 and less than 70");
        }
        else
        {
            Console.WriteLine(x + " is greater than 70");
        }
    }

    void LearnSwitch()
    {
        string name = "Asmita";
        switch(name)
        {
            case "Asmita":
            //code
            break;
            case "Asmit":
            //code
            break;
            case "Asmi":
            //code
            break;
            default:
            //code
            break;
        }
    }
    internal void LearnLoops()
    {
        // for (byte i=1; i<6; i++)
        // {
        //     Console.WriteLine(i + ".NET Training");
        // }

        string[] names = {"Rita","Sita","Harka","Anish"};
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }


        // byte j=1;
        // while(j<6)
        // {
        //     Console.WriteLine(j + ".NET Training");
        //     j++;
        // }
    }
}