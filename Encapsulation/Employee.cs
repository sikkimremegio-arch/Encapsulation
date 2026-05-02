using System;

public class Employee
{
    private string _name;

    public  Employee(string name)
    {
        _name = name;
    }
    public String Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            _name = "unknown";
            else 
                _name= value;
        }
    }
}

