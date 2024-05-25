using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction rlF1 = new Fraction();
        Console.WriteLine(rlF1.GetFractionString());
        Console.WriteLine(rlF1.GetDecimalValue());

        Fraction rlF2 = new Fraction(5);
        Console.WriteLine(rlF2.GetFractionString());
        Console.WriteLine(rlF2.GetDecimalValue());

        Fraction rlF3 = new Fraction(3, 4);
        Console.WriteLine(rlF3.GetFractionString());
        Console.WriteLine(rlF3.GetDecimalValue());  

        Fraction rlF4 = new Fraction(1, 3);
        Console.WriteLine(rlF4.GetFractionString());
        Console.WriteLine(rlF4.GetDecimalValue());
    }
}