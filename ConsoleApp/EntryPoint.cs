using Collect;
// using OOP;
using System;
using Patterns;
class EntryPoint
{
    public static void Main()
    {
        // // creating (instantiating) objects/instances
        // Person p1 = new();
        // // accessing static members
        // Person.scientificName="HomoSapiens";
        // // accessing instance members
        // p1.personName = "Asmita";
        // p1.heightInFt = 5.3f;
        // p1.age = 24;
        // p1.gender = "Female";
        // string details = p1.GetPersonDetails();
        // Console.WriteLine(details);

        // Collection coll = new();
        // coll.LearnArrays();

        // Basics strr = new();
        // strr.LearnLoops();
        
        // PatternGen pg = new();
        // pg.PatternGenerate();
        // pg.PatternGenerate1();
        // pg.PatternGenerate2();

        Methods m = new();
        // m.Print();
        // m.Print("Friend");
        // var d = m.Print("Asmita",20);
        // Console.WriteLine(d);
        // var g = m.Greet("David","Dr.");
        // Console.WriteLine(g);
        // Console.WriteLine(m.Greet("Rama"));
        // Console.WriteLine(m.Greet1("Rama"));
        m.FindIfEvenOrOdd(7);
        Console.WriteLine(m.IsEven(8));
    }

}

