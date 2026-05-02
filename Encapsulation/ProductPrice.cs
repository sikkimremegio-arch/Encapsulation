  using System;
namespace helloworld;
public class Product
{
    private double _price;

    public Product(double price)
    {
        _price = price;
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
                _price = value;
        }
    }

    public double TaxedPrice
    {
        get { return _price * 1.12; }
    }
}
