using System;
using System.Collections.Generic;

namespace LogarithmicLogicQuest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("We are KIKAY KOY Group");
            Console.WriteLine();
            Console.WriteLine("(Tinampay, Minoza, Timba, Saguirel, Tumaliwan)");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Welcome to Logarithmic Logic Quest!");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("RULES:");
            Console.WriteLine("Embark on a quest to recover lost computer data by solving logarithmic puzzles.");
            Console.WriteLine("Solve equations and inequalities to unlock the data's secrets.");
            Console.WriteLine("In this version, the game presents 10 random problems for the player to solve.");
            Console.WriteLine("The player must answer at least 5 of them correctly to successfully recover the lost data.");
            Console.WriteLine("The player's score is based on the number of correct answers out of the 10 problems presented.");
            Console.WriteLine("The players can enter 'quit' at any time to exit the game.");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("LET'S BEGIN");
            Console.WriteLine();
            Console.ReadKey();

            Console.Write("Enter the number of players (at least 5): ");
            if (int.TryParse(Console.ReadLine(), out int numberOfPlayers) && numberOfPlayers >= 5) // Number of players to solve the problem
            {
                List<string> playerNames = new List<string>();
                List<int> playerScores = new List<int>();

                for (int i = 0; i < numberOfPlayers; i++)
                {
                    Console.WriteLine();
                    Console.Write($"Enter Player {i + 1}'s Name: ");
                    string player = Console.ReadLine();
                    playerNames.Add(player);
                    playerScores.Add(0);
                    Console.WriteLine();
                }

                Random random = new Random();
                const int TotalProblems = 10; // Number of problems to solve
                const int CorrectAnswersToWin = 5; // Minimum correct answers required to recover the data

                for (int currentPlayer = 0; currentPlayer < numberOfPlayers; currentPlayer++)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"{playerNames[currentPlayer]}, it's your turn!");
                    Console.ReadKey();

                    for (int problemNumber = 1; problemNumber <= TotalProblems; problemNumber++)
                    {
                        double baseValue = random.Next(2, 6); // Random logarithmic base (2 to 5)
                        double exponent = random.Next(2, 11); // Random exponent (2 to 10)
                        double result = Math.Pow(baseValue, exponent);
                        bool isEquation = random.Next(0, 2) == 0; // Randomly choose between equation and inequality

                        if (isEquation)
                        {
                            Console.WriteLine($"\nProblem {problemNumber}: Solve the equation: log_{baseValue}({result}) = ?");
                        }
                        else
                        {
                            Console.WriteLine($"\nProblem {problemNumber}: Solve the inequality: log_{baseValue}({result}) < ?");
                        }

                        Console.Write("Your answer: ");
                        string userInput = Console.ReadLine().ToLower();

                        if (userInput == "quit")
                        {
                            Console.WriteLine($"Thanks for playing, {playerNames[currentPlayer]}!");
                            break;
                        }

                        if (double.TryParse(userInput, out double userAnswer))
                        {
                            double actualAnswer = isEquation ? exponent : exponent - 1;

                            if (userAnswer == actualAnswer)
                            {
                                Console.WriteLine($"You've GOT the C O R R E C T answer! You've unlocked a data.");
                                playerScores[currentPlayer]++;
                            }
                            else
                            {
                                Console.WriteLine($"I N C O R R E C T ! The correct answer is: {actualAnswer}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number or 'quit'.");
                        }

                    }

                    Console.WriteLine();
                    Console.WriteLine($"{playerNames[currentPlayer]}'s final score is: {playerScores[currentPlayer]}\n");

                    if (playerScores[currentPlayer] >= CorrectAnswersToWin)
                    {
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine($"C O N G R A T U L A T I O N S, {playerNames[currentPlayer]}!");
                        Console.WriteLine();
                        Console.WriteLine("You have successfully recovered the lost data!");
                        Console.WriteLine();
                        var data = new Data();
                        Console.WriteLine(data);
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine($"S O R R Y, {playerNames[currentPlayer]} 🙁");
                        Console.WriteLine();
                        Console.WriteLine("You didn't solve enough problems to recover the data.");
                        Console.WriteLine();
                        var sorry = new Sorry();
                        Console.WriteLine(sorry);
                    }

                }
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Game Results:");
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    Console.WriteLine($"{playerNames[i]}'s final score is: {playerScores[i]}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number of players (at least 5).");
            }

            Console.WriteLine();
            Console.WriteLine("THANK YOU for playing");
            Console.WriteLine("-KIKAY KOY-");
        }
    }

    public class Data
    {
        public Data()
        {
            string love = @"
  _________      __             ____        __        __     ______
||__     __|   ||  |         //  _   \    ||  |      |  |  ||  ____|
    ||  |      ||  |        //  /  \  \   ||  |      |  |  ||  |__
    ||  |      ||  |____   ||  |    |  |   \\  \    /  /   ||   __|
  __||  |__    ||       |   \\  \__/  /     \\  \__/  /    ||  |___
||_________|   ||_______|    \\______/       \\______/     ||______|
";
            string genmath = @"
             ______     ______     __      __     
           //  ____|  ||  ____|  ||   \   |  |
          ||  |  __   || |__     ||    \  |  |
          ||  |_|  |  ||  __|    ||  |\ \ |  |
          ||       |  || |____   ||  | \ \|  |
           \\______|  ||______|  ||__|  \____|

      __    __        ____       ________      __    __
    ||   \/   |    //  __  \   ||        |   ||  |  |  |
    ||        |   ||  |__|  |  ||__    __|   ||  |__|  |
    ||  |\/|  |   ||   __   |     ||  |      ||   __   |
    ||  |  |  |   ||  |  |  |     ||  |      ||  |  |  |
    ||__|  |__|   ||__|  |__|     ||__|      ||__|  |__|
";

            Console.WriteLine(love);
            Console.WriteLine(genmath);
        }
    }

    public class Sorry
    {
        public Sorry()
        {
            string sorry = @"
                          !!!                 !!!
                        !!!!!!!             !!!!!!!         
                       !!!   !!!           !!!   !!!
        
                                   !!!!!
                                 !!!!!!!!!
                               !!!       !!!
                             !!!           !!!
";
            Console.WriteLine(sorry);
        }
    }
}