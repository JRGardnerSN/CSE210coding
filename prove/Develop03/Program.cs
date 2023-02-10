using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string UserResponse = "";
        while (UserResponse.ToLower() != "quit") {
            Console.WriteLine("Mosiah 13:28");
            Console.WriteLine("And moreover, I say unto you, that salvation doth not come by the law alone; and were it not for the atonement, which God himself shall make for the sins and iniquities of his people, that they must unavoidably perish, notwithstanding the law of Moses.");

            Console.WriteLine();
            Console.WriteLine("Please press the enter key to hide words or type 'quit' to end the program:");
            UserResponse = Console.ReadLine();
        
            //This will clear the console
            Console.Clear();
            //This will show "BBB" in the console where "AAA" used to be
            Console.WriteLine("BBB");
        }
    }
}