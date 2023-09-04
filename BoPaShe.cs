using System;

public class BPS
{
    public static void Main()
    {
        bool gameLoop = true;
        int userPoints = 0;
        int computerPoints = 0;

        while (gameLoop)
        {
        Console.WriteLine("Welcome to play Boulders, Parchment, Shears!");
        Console.WriteLine("Pick a number for your choice and press enter:");

        Console.WriteLine("1.Rock");
        Console.WriteLine("2.Paper");
        Console.WriteLine("3.Scissors");

        string userChoice = Console.ReadLine();

        Random randomChoice = new Random();
        int computerChoice = randomChoice.Next(1,4);

        switch (computerChoice)
        {
            case 1:
            if (userChoice == "1")
            {
            //Tie
            Console.WriteLine("User chose Rock!");
            Console.WriteLine("Computer chose Rock!");
            Console.WriteLine("It is a tie.");
            }

            else if (userChoice == "2")
            {
            Console.WriteLine("User chose Paper!");
            Console.WriteLine("Computer chose Rock!");
            Console.WriteLine("User wins!");
            userPoints++;
            }

            else if (userChoice == "3")
            {
            Console.WriteLine("User chose Scissors!");
            Console.WriteLine("Computer chose Rock!");
            Console.WriteLine("Computer wins!");
            computerPoints++;
            }
            else
            {
            Console.WriteLine("Please choose 1, 2 or 3!");
            }
            break;

            case 2:
            {
            Console.WriteLine("User chose Rock!");
            Console.WriteLine("Computer chose Paper!");
            Console.WriteLine("Computer wins!");
            computerPoints++;
            }

            else if (userChoice == "2")
            {
            //Tie
            Console.WriteLine("User chose Paper!");
            Console.WriteLine("Computer chose Paper!");
            Console.WriteLine("It is a tie.");
            }
            else if (userChoice == "3")
            {
            Console.WriteLine("User chose Scissors!");
            Console.WriteLine("Computer chose Paper!");
            Console.WriteLine("User wins!");
            userPoints++;
            }
            break;

            case 3:
            if (userChoice == "1")
            {
        
            Console.WriteLine("User chose Rock!");
            Console.WriteLine("Computer chose Scissors!");
            Console.WriteLine("User wins!");
            userPoints++;
            }

            else if (userChoice == "2")
            {
            Console.WriteLine("User chose Paper!");
            Console.WriteLine("Computer chose Scissors!");
            Console.WriteLine("Computer wins!");
            computerPoints++;
            }
            else if (userChoice == "3")
            {
            //Tie
            Console.WriteLine("User chose Scissors!");
            Console.WriteLine("Computer chose Scissors!");
            Console.WriteLine("It is a tie.");
            }
            break;
            }
            Console.WriteLine("Do you wish to play again?");
            Console.WriteLine("Enter Y or N");

            Console.ReadLine();
            if (playAgain == "N" || playAgain == "n") 
            {
            gameLoop = false;
            Console.WriteLine($"User has {userPoints} points - Computer has {computerPoints} points");
            Console.WriteLine("Thank you for playing. Restart to start over.");
            }
        }

    }
}