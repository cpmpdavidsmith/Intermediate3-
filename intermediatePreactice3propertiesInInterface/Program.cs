using System;

namespace Demo
{
    // Define the interface
    public interface IScore
    {
        // Read-write property
        int Score { get; set; }

        // Read-write property
        string Try { get; set; }

        // Read-only property
        int PlayerID { get; }
    }

    public class Player : IScore
    {
        // Private fields for encapsulation
        private int playerID;
        private string playerName;
        private int score;
        private string tryValue;

        // Implementing the interface properties
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Try
        {
            get { return tryValue; }
            set { tryValue = value; }
        }

        public int PlayerID
        {
            get { return playerID; }
        }

        // Constructor to set initial values
        public Player()
        {
            playerID = 1; // You can set the default value here
            playerName = "John"; // You can set the default value here
        }
    }

    class Program
    {
        // The main function
        static void Main(string[] args)
        {
            // Create an instance of Player
            Player player1 = new Player();

            // Set properties for the player
            player1.Score = 20;
            player1.Try = "first try";

            // Display the properties
            Console.WriteLine("The score is " + player1.Score);
            Console.WriteLine("The try is the " + player1.Try);
            Console.WriteLine("The PlayerID is " + player1.PlayerID);

            Console.Read();
        }
    }
}
