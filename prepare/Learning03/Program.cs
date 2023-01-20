using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction testing = new Fraction();
        Fraction testing2 = new Fraction(6);
        Fraction testing3 = new Fraction(6, 7);
        //Console.WriteLine("Hello Learning03 World!");

        //testing.GetTop();
        //testing2.GetTop();
        //testing3.GetTop();
        testing3.GetFractionString();
        testing3.GetDecimalValue();
    }
}