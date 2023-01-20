using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
            Console.ResetColor();

            string playerInput = Console.ReadLine();

            if (playerInput == "r" || playerInput == "R" || playerInput == "rock" || playerInput == "Rock")
            {
                playerInput = Rock;
            }

            else if (playerInput == "p" || playerInput == "P" || playerInput == "paper" || playerInput == "Paper")
            {
                playerInput = Paper;
            }

            else if (playerInput == "S" || playerInput == "s" || playerInput == "scissors" || playerInput == "Scissors")
            {
                playerInput = Scissors;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Invalid input. Try again...");
                Console.ResetColor();
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = string.Empty;

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Rock; break;
                case 2:
                    computerMove = Paper; break;
                case 3:
                    computerMove = Scissors; break;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The computer chose {computerMove}.");
            Console.ResetColor();

            if ((playerInput == Rock && computerMove == Scissors) || (playerInput == Paper && computerMove == Rock) || (playerInput == Scissors && computerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                Console.ResetColor();
            }

            else if ((playerInput == Rock && computerMove == Paper) || (playerInput == Paper && computerMove == Scissors) || (playerInput == Scissors && computerMove == Rock))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lost!");
                Console.ResetColor();
            }

            else if ((playerInput == Rock && computerMove == Rock) || (playerInput == Scissors && computerMove == Scissors) || (playerInput == Paper && computerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Draw.");
                Console.ResetColor();
            }
        }
    }
}