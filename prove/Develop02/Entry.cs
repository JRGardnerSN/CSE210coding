using System;
using System.IO;

public class Entry
{
    public static void recordEntry(){
        DateTime theCurrentTime = DateTime.Now;
        string dateTimeStringVer = theCurrentTime.ToShortDateString();
        string userEntry = Console.ReadLine();
        string journalHistName = "JournalHistory.txt";
        using (StreamWriter outputFile = new StreamWriter(journalHistName)){
            outputFile.WriteLine($"►Date: {dateTimeStringVer} --- {userEntry}"); //We are using ► as a seperator for our .txt
        }
        
    }
}



// // Don't forget to put this at the top, so C# knows where to find the StreamWriter class
// using System.IO; 
// ...
// string fileName = "myFile.txt";
// using (StreamWriter outputFile = new StreamWriter(filename))
// {
//     // You can add text to the file with the WriteLine method
//     outputFile.WriteLine("This will be the first line in the file.");
//     // You can use the $ and include variables just like with Console.WriteLine
//     string color = "Blue";
//     outputFile.WriteLine($"My favorite color is {color}");



// DateTime theCurrentTime = DateTime.Now;
// string dateText = theCurrentTime.ToShortDateString();