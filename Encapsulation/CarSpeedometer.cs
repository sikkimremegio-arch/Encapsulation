using System;

public class CarSpeedometer
{
    private int _speed;

    public CarSpeedometer(int speed)
    {
        Speed = speed;
    }

    public int Speed
    {
        get { return _speed; }
        set
        {
            if (value >= 0 && value <= 200)
                _speed = value;
        }
    }
}