public class Fraction

{
    private int _numerator; // numerator
    private int _denominator; // denominator 


    // constructor with no parameters
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // constructor with one parameter

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // constructor with two parameters
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    // Setter numerator

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getter denominator
    public int GetDominator()

    {
        return _denominator;
    }

    // Setter denominator
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    //Return fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    //Return the decimal value of this fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}