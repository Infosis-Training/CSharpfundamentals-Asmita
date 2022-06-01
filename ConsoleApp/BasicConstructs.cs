
class Basics
{
    public static void Main()
    {
        LearnLoops();
        // LearnConditionals(55);
        // LearnConditionals(80);
    }
    static void LearnConditionals(byte x)
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
    static void LearnLoops()
    {
        for (byte i=0; i<5; i++)
        {
            Console.WriteLine(i + ".NET Training");
        }
        byte j=0;
        while(j<5)
        {
            Console.WriteLine(j + ".NET Training");
            j++;
        }
    }
}