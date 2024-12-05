using System;

class Program
{
    static void Main(string[] args)
    {
        //fractions with constructors
        Fraction f1 = new Fraction(); // without parameters
        Fraction f2 = new Fraction(5); // One parameter
        Fraction f3 = new Fraction(3, 4); // Two parameters
        Fraction f4 = new Fraction(1, 3);


        //Show fractions and their decimal values
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // getters and setters

        f1.SetNumerator(7);
        f1.SetDenominator(2);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

    }
}