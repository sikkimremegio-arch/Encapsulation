using System;

public class WaterTankLevel
{
    private double _liters;

    public WaterTankLevel (double liters)
    {
        _liters = liters;
    }
    public double liters
    {
        get {  return _liters; }
        set
        {
            if ( value > 500)
                _liters = 500;
            else
                _liters = value;
        }
    }

    
}
