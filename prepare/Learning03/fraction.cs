using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        numerator = top;
        if (bottom != 0)
            denominator = bottom;
        else
            throw new ArgumentException("Denominator cannot be zero.");
    }

    
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value != 0)
                denominator = value;
            else
                throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    
    public string GetFractionString()
    {
        return numerator + "/" + denominator;
    }

    
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
