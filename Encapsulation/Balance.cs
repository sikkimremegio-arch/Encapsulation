using System;

public class BankAccount
{
    private double _Balance;

    public BankAccount(double balance)
    {
        _Balance = balance;
    }
    public double Balance
    {
        get { return _Balance; }
        set
        {
            if (_Balance <0)
                Balance = _Balance;

        }
    }
}
