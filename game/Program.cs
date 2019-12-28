using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, gameInput;
            int randomInt;
            bool playAgain = true;
            bool goodKey = true;

            

            Console.WriteLine("Welcome in the paper, scissors, rock game");

            while (playAgain)
            {
                int userScore = 0;
                int compScore = 0;
                while (userScore < 3 && compScore < 3)
                {
                    Console.WriteLine("Choose between paper, scissors and rock");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();



                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);



                    switch (randomInt)
                    {
                        case 1:
                            gameInput = "ROCK";
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer chose ROCK, it is a draw");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer chose ROCK, computer won");
                                compScore++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer chose ROCK, You won");
                                userScore++;
                            }
                            break;
                        case 2:
                            gameInput = "SCISSORS";
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer chose SCISSORS, it is a draw");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer chose SCISSORS, You won");
                                userScore++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer chose SCISSORS, Computer won");
                                compScore++;
                            }
                            break;
                        case 3:
                            gameInput = "PAPER";
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer chose PAPER, it is a draw");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer chose PAPER, Computer won");
                                compScore++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer chose PAPER, You won");
                                userScore++;
                            }
                            break;

                    }
                    Console.WriteLine("Computer: {0}, You: {1}", compScore, userScore);
                }




                if (userScore == 3)
                {
                    Console.WriteLine("User won");
                    playAgain = true;
                }
                else if (compScore == 3)
                {
                    Console.WriteLine("Computer won");
                    playAgain = false;
                }

                
                while (goodKey)
                {
                    Console.WriteLine("Do You want to play again? y/n");
                    string again = Console.ReadLine();

                    if (again == "y")
                    {
                        playAgain = true;
                        goodKey = false;
                        Console.Clear();
                    }
                    else if (again == "n")
                    {
                        playAgain = false;
                        Console.WriteLine("Bye");
                        goodKey = false;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Wrong text. Please write it again");
                    }
                }
            }
        }
    }
}
