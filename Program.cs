using System;

namespace PvP
{
    class GameRun
    {
        static GameRun()
        {
            Console.WriteLine("Game Starting..... ");
            Console.WriteLine("🥊 Welcome to the Fighting Game of Your Dreams! 🥊");
            Console.WriteLine("In this game, you'll choose your player and fight against the opponent.");
            Console.WriteLine("👊 There are three kinds of players available: 👊");
            Console.WriteLine("1. THE UNDERTAKER 🧟‍♂️:");
            Console.WriteLine("   - Health: 100");
            Console.WriteLine("   - Damage to Opponent: 10");
            Console.WriteLine("   - Healing Factor: 10");
            Console.WriteLine("2. JOHN CENA 💪:");
            Console.WriteLine("   - Health: 50");
            Console.WriteLine("   - Damage to Opponent: 50");
            Console.WriteLine("   - Healing Factor: 50");
            Console.WriteLine("3. BROCK LESNAR 🤼:");
            Console.WriteLine("   - Health: 10");
            Console.WriteLine("   - Damage to Opponent: 100");
            Console.WriteLine("   - Healing Factor: 100");
        }

        public static void Main(string[] args)
        {
            Other.Intro(1);
            int player1 = Other.Option();
            Player playerA = new Player(player1);
            Other.Intro(2);
            int player2 = Other.Option();
            Player playerB = new Player(player2);
            Game.Start(playerA, playerB);

        }

    }


}