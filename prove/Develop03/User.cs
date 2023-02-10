using System;

public class User {
        //►
    string _username = "";
    string _password = "";
    //List<Scripture> _favoriteSrciptures = new List<Scripture>();
}

//I think that everything below is unnecessary
public class UserInterface {

    public static void startUser() {
        Console.WriteLine("Please select an action:");
        Console.WriteLine();
        Console.WriteLine("1. Create new user");
        Console.WriteLine("2. Load existing user");
        // Console.WriteLine("3. ");
        string numberSelect = Console.ReadLine();
        if (numberSelect == "1") {
            Console.Clear();
            Console.WriteLine("Username: ");
            string newUsername = Console.ReadLine();
            Console.WriteLine("Password: ");
            string newPassword = Console.ReadLine();
            
        }
    }
}