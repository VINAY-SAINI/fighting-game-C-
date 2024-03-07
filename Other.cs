using System.Security.Cryptography;

namespace PvP
{
    class Other
    {
        public static void Intro(int n)
        {
            Console.WriteLine($"Player {n} ");
            Console.WriteLine("For The UnderTaker Press 1");
            Console.WriteLine("For John Cena Press 2");
            Console.WriteLine("For Brock Lesnar Press 3");
        }
        public static int Option()
        {
            int player1;
            try
            {
                player1 = Convert.ToInt32(Console.ReadLine());
                while (!(player1 > 0 && player1 < 4))
                {
                    Console.WriteLine("Please choose between 1 and 3");
                    player1 = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                // Recursively call Option method to prompt user again
                return Option();
            }

            return player1;
        }

    }
}