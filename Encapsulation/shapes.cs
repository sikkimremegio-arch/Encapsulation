using System;


public class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        Radius = radius; 
    }

    public double Radius
    {
        get { return _radius; }
        set
        {
            if (value > 0)
                _radius = value;
        }
    }

    public double Area
    {
        get { return 3.14 * _radius * _radius; }
    }
}
