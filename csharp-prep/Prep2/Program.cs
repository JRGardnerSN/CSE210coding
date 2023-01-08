using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade by percentage? (please round)");
        string number = Console.ReadLine();
        int percent = int.Parse(number);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "c";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // string plusminus = "";
        // int dec = 10;

        // int remainder = Math.DivRem(percent, dec);

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else{
            Console.WriteLine("Keep trying! You'll do better next time.");
        }
    }
}