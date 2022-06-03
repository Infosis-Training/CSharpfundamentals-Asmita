

using System;

class Assignment
{
    public string FindGreatestNumber(byte x, byte y, byte z )
    {
        if (x>y)
        {
            if (x>z)
            {
                return $"{x} is greater than {y} and {z}";
            }
            else
            {
                return $"{z} is greater than {y} and {x}";
            }
        }
        else if(y>z)
        {
            return $"{y} is greater than {x} and {z}";
        }
        else
        {
            return $"{z} is greater than {x} and {y}";
        }
    }
    public string ProductOfNumbers(float x, float y, float z = 1.0f)
    {
        return $"The product of numbers are {x*y*z}";
    }
    // public void DisplayFirstLetter(string fullName)
    // {
    //     // string fullName = "Asmita Gautam"; 
    //     string[] strSplit = fullName.Split(" ");
    //     foreach(string st in strSplit)
    //     {
    //         Console.Write(st.Substring(0,1));
    //     }
    // }
    public string GetInitials(string firstName, string secondName)
    {
        string initials = $"{firstName[0]}{secondName[0]}";
        return $"The initials of name is {initials.ToUpper()}"; 
    }
}