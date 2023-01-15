using System;
using System.IO;

public class Journal
{
    public static void loadJournal(){
        string journalHistName = "JournalHistory.txt";
        string[] eachEntry = System.IO.File.ReadAllLines(journalHistName);
        foreach (string line in eachEntry){
        string[] parts = line.Split("►");
        string firstName = parts[0];
        string lastName = parts[1];
        }
    }
}

// string fileName = "myFile.txt";

// using (StreamWriter outputFile = new StreamWriter(filename))
// {
//     // You can add text to the file with the WriteLine method
//     outputFile.WriteLine("This will be the first line in the file.");
    
//     // You can use the $ and include variables just like with Console.WriteLine
//     string color = "Blue";
//     outputFile.WriteLine($"My favorite color is {color}");
// }