using System;

public class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int firstNumber, int secondNumber) {
        _top = firstNumber;
        _bottom = secondNumber;
    }

    public void GetTop() {
        int valueTop = _top;
        string valTop = Convert.ToString(valueTop);
        Console.WriteLine(valTop);
    }
    public void GetBottom() {
        int valueBottom = _bottom;
        string valBottom = Convert.ToString(valueBottom);
        Console.WriteLine(valBottom);
    }
    public void SetTop(int top) {
        _top = top;
    }
    public void SetBottom(int bottom) {
        _bottom = bottom;
    }

    public void GetFractionString() {
        int valueTop = _top;
        string valTop = Convert.ToString(valueTop);
        int valueBottom = _bottom;
        string valBottom = Convert.ToString(valueBottom);
        Console.WriteLine($"{valTop}/{valBottom}");
    }
    public void GetDecimalValue() {
        double decimalValue;
        double topValue = _top;
        double bottomValue = _bottom;
        decimalValue = topValue / bottomValue;
        string decimalValueString = Convert.ToString(decimalValue);
        Console.WriteLine($"{decimalValueString}");
    }
}