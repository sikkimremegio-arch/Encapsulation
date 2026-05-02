using System;


public class Student
{
    private int _Grade;

    public Student(int Grade)
    {
        _Grade = Grade;

    }
    public int Grade
    {
        get { return _Grade; }
        set
        {
            if (_Grade != value)
            {
                _Grade = value;
            }
        }


    }
}