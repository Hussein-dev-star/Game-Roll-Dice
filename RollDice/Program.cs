using System;

namespace RollDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int PlayerPoint = 0;
            int EnemyPoint = 0;
            Random Dice = new Random();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Welcome();
            DiceGame(Dice,ref PlayerPoint, ref EnemyPoint);
            ResultGame(PlayerPoint,EnemyPoint);


           Console.ReadKey();
        }

        //💌 welcome Method
        static void Welcome()
        {
            Console.WriteLine("Welcome Player to Inn Gambler 🍺");
            Console.WriteLine("do you want to join us for a game Type y/n 😀");
            char answer = Getchar();
            if (answer == 'y')
            {
                Console.WriteLine("LET'S GOOOO 😆");
            }
            else
            {
                Console.WriteLine("Oh.....,😢 Maybe next time! Thanks for visiting the Inn.");
                Environment.Exit(0);
            }
        }

        //⚠️input invalde
        static char Getchar()
        {
            char choice;

            while (!char.TryParse(Console.ReadLine().ToLower(), out choice) || (choice != 'y' && choice != 'n')) {
                Console.WriteLine("Enter y/n only⚠️");
            }
            return choice;
        }

        //🎲 Roll the dice
        static int RollDice(Random dice)
        {
            return dice.Next(1, 7);
        }

        //🎮 the game
        static void DiceGame(Random dice,ref int PlayerPoint, ref int EnemyPoint)
        {
        int PlayerDice = 0;
        int EnemyDice = 0;
        const int Round = 5;
            Console.WriteLine("The game is simple you will 🔥ROOOlll🔥 the dice \n who has more point win 🏆");
            NewLine();
            for (int i = 0; i < Round; i++)
            {
                Console.WriteLine("Press 'Enter' to Start the Game 🎲");
                Console.ReadLine();
                PlayerDice = RollDice(dice);
                Console.WriteLine($"The player Rolled {PlayerDice}");
                NewLine();
                Console.WriteLine("Now it is AI turn");
                EnemyDice = RollDice(dice);
                Console.WriteLine($"The AI Rolled {EnemyDice}");
                NewLine();
                if (PlayerDice < EnemyDice)
                {
                    Console.WriteLine("The AI Won this round");
                    EnemyPoint++;
                }
                else if (EnemyDice < PlayerDice)
                {
                    Console.WriteLine("You Won this round🏅");
                    PlayerPoint++;
                }
                else
                {
                    Console.WriteLine("IT IS DRAW 😮");
                }
                NewLine();
                Console.WriteLine($"The point is AI:{EnemyPoint}|Player:{PlayerPoint}");
            }
        }

        //🎇 The result
        static void ResultGame(int PlayerPoint ,int EnemyPoint)
        {
            if (PlayerPoint < EnemyPoint)
            {
                Console.WriteLine("the AI WON");
            }
            else if (EnemyPoint < PlayerPoint)
            {
                Console.WriteLine("You WON🎇");
            }else { Console.WriteLine("IT IS DRAW"); }

        }

        //✨ To Clean the code 
        static void NewLine()
        {
            Console.WriteLine("-------------------------");
        }
    }
}
