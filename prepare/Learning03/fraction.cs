using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _buttom;

    public Fraction()
    {
        _top = 1;
        _buttom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _buttom = 1;
    }

    public Fraction(int top, int buttom)
    {
        _top = top;
        _buttom = buttom;
    }

    public void SetTop(){}
    public void SetButtom(){}

    public int GetTop()
    {
        return _top;
    }

    public int GetButtom()
    {
        return _buttom;
    }
  
}