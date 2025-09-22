namespace PRS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of players: ");
            int count = Convert.ToInt32(Console.ReadLine());
            MultiplePlayers(count);
        }
        static string Game()
        {
            Random random = new Random();
            string[] choices = { "Rock", "Paper", "Scissors" };
            int index = random.Next(choices.Length);
            string computerChoice = choices[index];
            return computerChoice;
        }
        static void Check(string player1, string player2)
        {
            while (player1 != player2)
            {
                if (player1 == "Rock" && player2 == "Scissors")
                {
                    Console.WriteLine("Player 1 wins");
                    break;
                }
                else if (player1 == "Paper" && player2 == "Rock")
                {
                    Console.WriteLine("Player 1 wins");
                    break;
                }
                else if (player1 == "Scissors" && player2 == "Paper")
                {
                    Console.WriteLine("Player 1 wins");
                    break;
                }
                else if (player2 == "Rock" && player1 == "Scissors")
                {
                    Console.WriteLine("Player 2 wins");
                    break;
                }
                else if (player2 == "Paper" && player1 == "Rock")
                {
                    Console.WriteLine("Player 2 wins");
                    break;
                }
                else if (player2 == "Scissors" && player1 == "Paper")
                {
                    Console.WriteLine("Player 2 wins");
                    break;
                }
            }
        }
        static string CheckMultiple(string[] players)
        {
            string winner = players[0];

            for (int i = 1; i < players.Length; i++)
            {
                string opponent = players[i];
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"Match: {winner} vs {opponent}");

                // Replay until there's a winner
                while (winner == opponent)
                {
                    Console.WriteLine("It's a tie! Replaying...");
                    winner = Game();
                    opponent = Game();
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine($"New match: {winner} vs {opponent}");
                }

                // Decide who wins
                if ((winner == "Rock" && opponent == "Scissors") ||
                    (winner == "Paper" && opponent == "Rock") ||
                    (winner == "Scissors" && opponent == "Paper"))
                {
                    Console.WriteLine("Winner: " + winner);
                }
                else
                {
                    winner = opponent;
                    Console.WriteLine("Winner: " + winner);
                }
            }

            return winner;
        }
        static void CheckTie(string player1, string player2)
        {
            while (player1 == player2)
            {
                Console.WriteLine("It's a tie! Let's play again.");
                player1 = Game();
                Console.WriteLine("Player 1 chose: " + player1);
                player2 = Game();
                Console.WriteLine("Player 2 chose: " + player2);
                Check(player1, player2);
            }
        }
        static void MultiplePlayers(int count)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("--------------------------------------------------------");
            string[] players = new string[count];

            for (int i = 0; i < count; i++)
            {
                players[i] = Game();
                Console.WriteLine("Player " + (i + 1) + " chose: " + players[i]);
            }

            string finalWinner = CheckMultiple(players);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Final Winner: " + finalWinner);
        }
    }
}
