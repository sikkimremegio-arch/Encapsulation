using System;

public class TemperatureConverter
{
    private double _celsius;

    public TemperatureConverter(double celsius)
    {
        _celsius = celsius;
    }
    public double Celsius
    {
        get { return _celsius; }
        set { _celsius = Celsius; }

    }
    
    public double Fahrenheit
    {
       get { return (_celsius * 1.8) + 32; }
      
    }
}
