using System;
using System.Collections.Generic;
using System.IO;

class Prompt
{
    //PUT A LIST IN HERE
    public static void generatePrompt(){
        var randomChoice = new Random();
        List<string> listOfPrompts = new List<string>(new string[] {
            "What is something new you did today?",
            "Who is a friend that you admire?",
            "What is one thing you want to improve about yourself?",
            "Where did you go that sticks out in your mind?",
            "How many times did you say thank you today?",
            "When did you go to work today?",
            "When did you see the Lord's hand in your life today?",
            "Is your family doing well today?",
            "How are things at home?"});
        int promptIndex = randomChoice.Next(0, 8);
        string newPrompt = listOfPrompts[promptIndex];
        string journalHistName = "JournalHistory.txt";
        using (StreamWriter outputFile = new StreamWriter(journalHistName)){
            outputFile.WriteLine($"►Prompt: {newPrompt} "); //We are using ► as a seperator for our .txt
        }
        Console.WriteLine(newPrompt);
    }
}