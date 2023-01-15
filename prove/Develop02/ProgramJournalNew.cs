using System;

public class ProgramJourn{
    static void Main(string[] args)
    {
        //PUT A WHILE LOOP IN HERE

                //THIS SHOULD ACT AS THE MENU (maybe)
        //Please write one of the following numbers to perform an action
        //1.Write
        //2.Display
        //3.Load
        //4.Save
        //5.Quit
        int numChoice = 20;
        Console.WriteLine("Hello! Welcome to the Journal & Prompt Progam!");
        while (numChoice != 19){
            if (numChoice == 20){
                Console.WriteLine("");
                Console.WriteLine("Please type one of the following numbers to perform an action:");
                Console.WriteLine("1. Just Write");
                Console.WriteLine("2. Generate a writing prompt");
                Console.WriteLine("3. Load previous journal entries");
                // Console.WriteLine("4. Write a memory from the past");
                Console.WriteLine("4. Quit the program");
                string userInput = Console.ReadLine();
                numChoice = Convert.ToInt32(userInput);
            }
            else if (numChoice == 1){
                Entry.recordEntry();
                numChoice = 20;
            }
            else if (numChoice == 2){
                Prompt.generatePrompt();
                Entry.recordEntry();
                numChoice = 20;
            }
            else if (numChoice == 3){
                Journal.loadJournal();
                numChoice = 20;
            }
            // else if (numChoice == 4){

            //     numChoice = 20;
            // }
            else if (numChoice == 4){
                numChoice = 19;
            }
        }
    }
}