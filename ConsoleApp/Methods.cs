using System;

class Methods
{
    // simplest possible: no return type,no parameters
    public void Print()
    {
        Console.WriteLine("Hello there..");
    }
    // no return type,takes some parameters
    public void Print(string name) => Console.WriteLine("Hello," + name + "...");
    
    // one return type,mutliple arguments
    public string Print(string name, byte age)
    {
        string details = $"I am  {name}. I am {age} years old.";
        return details;
    }
    // optional argument
    public string Greet(string name, string salutation = "Ms.") 
    {
        return $"Hello, {salutation} {name}";
    }
    // same as above; for single line we can use =>
    public string Greet1(string name, string salutation = "Ms.") => $"Hello, {salutation} {name}";

    //write a method to find if no is odd or even
    public void FindIfEvenOrOdd(int x)
    {
        if (x%2 == 1)
        {
            Console.WriteLine("odd");
        }
        else
        {
            Console.WriteLine("even");
        }
    }
    public bool IsEven(int num)=>num%2==0;

    // returning multiple values, using tuple
    public  (int, int) FindMinMax(byte x, byte y, byte z)
    {
        Assignment a = new();
        int max = a.GetMax(x, y, z);
        int min = a.GetMin(x, y, z);
        // return $"The Min and Max Values are {min, max}";
        return (min,max);
    }
}