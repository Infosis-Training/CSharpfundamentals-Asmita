using System;
class HomeProperties
{
    public string bellRing;
    public string CheckIFBellRings
    {
        get
        {
            return bellRing;
        }
        set
        {
            if (value.Length > 2)
            {
                bellRing = value;
            }
        }
    }
    public bool IsAvailable;

    public bool IsPersonAvailable
    {
        get
        {
            return IsAvailable;
        }
        set
        {
            IsAvailable = false;
        }

    }
}
class IsDesignCompleted : HomeProperties, INewInterface
{
    public string CheckIFCompleted;
    public string CheckingStatusOfCompletion
    {
        get
        {
            return CheckIFCompleted;
        }
    }

    public static int FindSum(int x, int y) => x + y;
    // {
    // int result = IsDesignCompleted.FindSum(10,20);
    // Console.WriteLine(result);
    // return result;
    // }
    public void Method1OfInterface()
    {
        Console.WriteLine("Hello from interface1");
    }
    public void Method2OfInterface()=> Console.WriteLine("Hello from interface2");

}
interface INewInterface
{
    void Method1OfInterface();
    void Method2OfInterface();

}