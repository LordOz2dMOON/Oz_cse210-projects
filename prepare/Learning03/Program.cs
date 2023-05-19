using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number = new Fraction();
        Fraction numberOne = new Fraction(1);
        Fraction numberTwo = new Fraction(5);
        Fraction numberThree = new Fraction(3, 4);
        Fraction numberFour = new Fraction(1,3);

        Console.WriteLine(number.GetFractionString());
        Console.WriteLine(number.GetTop());
        Console.WriteLine(numberTwo.GetFractionString());
        Console.WriteLine(numberTwo.GetTop());
        Console.WriteLine(numberThree.GetFractionString());
        Console.WriteLine(numberThree.GetDecimalValue());
        Console.WriteLine(numberFour.GetFractionString());
        Console.WriteLine(numberFour.GetDecimalValue());

    }
}