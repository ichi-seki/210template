using System.Transactions;

class Bin
{
    private string _denomination;
    private double _value;
    private int _count;

    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }

    public int GetCount()
    {
        return _count;
    }

    public double GetValue()
    {
        return _value;
    }

    public void Transact(int delta)
    {
        _count += delta;
    }
}