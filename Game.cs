
namespace PvP
{
    class Game
    {
        public static void Start(Player player1, Player player2)
        {
            while (player1.health > 0 && player2.health > 0)
            {
                // Player 1's turn
                Console.WriteLine($"Choose {player1.name}");
                Console.WriteLine("For Heal, choose 1");
                Console.WriteLine("For Attack, choose 2");

                int moveOption1 = GetValidInput();

                if (moveOption1 == 1)
                {
                    player1.Healing();
                }
                else if (moveOption1 == 2)
                {
                    player1.Attack(player2);
                }
                if (player2.health <= 0)
                {
                    Environment.Exit(0);
                    break;
                }
                // Player 2's turn
                Console.WriteLine($"Choose {player2.name}");
                Console.WriteLine("For Heal, choose 1");
                Console.WriteLine("For Attack, choose 2");
                
                int moveOption2 = GetValidInput();

                if (moveOption2 == 1)
                {
                    player2.Healing();
                }
                else if (moveOption2 == 2)
                {
                    player2.Attack(player1);
                }
            }
        }
        private static int GetValidInput()
        {
            int option;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out option) || (option != 1 && option != 2))
                {
                    Console.WriteLine("Invalid input. Please enter 1 for Heal or 2 for Attack.");
                }
                else
                {
                    break; // Break out of the loop if input is valid
                }
            }
            return option;
        }

    }


}