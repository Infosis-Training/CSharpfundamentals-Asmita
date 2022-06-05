using System;
class Properties
{
    string _name;
    double average;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value.Length >= 2)
            {
                _name = value;
            }
        }

    }

    public string Average
    {
       get; set;
    }

    public string Address {get; set;}
}
