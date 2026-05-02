using System;
public class StepCounter
{
    private int _steps;

    public StepCounter()
    {
    }

    public StepCounter(int Steps)
    {
        _steps = Steps;
    }

    public int Steps
    {
        get { return _steps; }
        set
        {
            if (value > _steps) 
                _steps = value;
        }
    }

    public double DistanceInKm
    {
        get { return _steps * 0.0008; }
    }
}
