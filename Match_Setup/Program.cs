namespace Match_Setup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int player1, player2, player3, player4;

            // Generate distinct random numbers for each player
            player1 = random.Next(1, 5); // Generates 1 to 4
            do
            {
                player2 = random.Next(1, 5);
            } while (player2 == player1);

            do
            {
                player3 = random.Next(1, 5);
            } while (player3 == player1 || player3 == player2);

            do
            {
                player4 = random.Next(1, 5);
            } while (player4 == player1 || player4 == player2 || player4 == player3);

            Random random1 = new Random();
            int index, index1, index2, index3, index4, index5, index6, index7;
            string[] choices = { "PSG", "MNU", "LIV", "JUV", "BAY", "RMA", "BAR", "MCI", "ATH", "CHE" };

            index = random1.Next(choices.Length);
            string team1 = choices[index];

            do
            {
                index1 = random1.Next(choices.Length);
            } while (index1 == index);
            string team2 = choices[index1];

            do
            {
                index2 = random1.Next(choices.Length);
            } while (index2 == index || index2 == index1);
            string team3 = choices[index2];

            do
            {
                index3 = random1.Next(choices.Length);
            } while (index3 == index || index3 == index1 || index3 == index2);
            string team4 = choices[index3];

            do
            {
                index4 = random1.Next(choices.Length);
            } while (index4 == index || index4 == index1 || index4 == index2 || index4 == index3);
            string team5 = choices[index4];

            do
            {
                index5 = random1.Next(choices.Length);
            } while (index5 == index || index5 == index1 || index5 == index2 || index5 == index3 || index5 == index4);
            string team6 = choices[index5];

            do
            {
                index6 = random1.Next(choices.Length);
            } while (index6 == index || index6 == index1 || index6 == index2 || index6 == index3 || index6 == index4 || index6 == index5);
            string team7 = choices[index6];

            do
            {
                index7 = random1.Next(choices.Length);
            } while (index7 == index || index7 == index1 || index7 == index2 || index7 == index3 || index7 == index4 || index7 == index5 || index7 == index6);
            string team8 = choices[index7];

            Console.WriteLine("Richie: player {0}, teams: {1}, {2}", player1, team1, team2);
            Console.WriteLine("Austin: player {0}, teams: {1}, {2}", player2, team3, team4);
            Console.WriteLine("Ernest: player {0}, teams: {1}, {2}", player3, team5, team6);
            Console.WriteLine("Gerald: player {0}, teams: {1}, {2}", player4, team7, team8);
            Console.WriteLine("--------------------------------------------------------");
            Random random2 = new Random();
            int index8, index9, index10, index11;
            int[] matches = { player1, player2, player3, player4 };
            index8 = random2.Next(matches.Length);
            int play1 = matches[index8];

            do
            {
                index9 = random2.Next(matches.Length);
            } while (index9 == index8);
            int play2 = matches[index9];

            Console.WriteLine("Match 1: player {0} vs player {1}", play1, play2);

            do
            {
                index10 = random2.Next(matches.Length);
            } while (index10 == index8 || index10 == index9);
            int play3 = matches[index10];

            do
            {
                index11 = random2.Next(matches.Length);
            } while (index11 == index8 || index11 == index9 || index11 == index10);
            int play4 = matches[index11];

            Console.WriteLine("Match 2: player {0} vs player {1}", play3, play4);
            Console.WriteLine("--------------------------------------------------------");

        }
    }
}
