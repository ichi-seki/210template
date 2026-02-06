class Till
{
    private List<Bin> _bins;
    public Till()
    {
        _bins = new List<Bin>();
        _bins.Add(new Bin());
    }

    public double TotalCash()
    {
        double total = 0.0;
        foreach (Bin b in _bins)
        {
            total += b.TotalBinCash();
        }
        return total;
    }

    public void ExchangeCash(int count, double value)
    {
        switch (value)
        {
            case 0.01:
            _bins[]
        }
    }
};