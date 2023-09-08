namespace ROCKPAPERSCISSORS

{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;
            while (playAgain)
            {
                int scorePlayer = 0, scoreCPU = 0;

                while (scoreCPU < 3 && scorePlayer < 3)
                {
                    Console.Write("Choose ROCK, PAPER or SCISSORS?\n");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            System.Console.WriteLine("Computer chose Rock\n");

                            if (inputPlayer == "ROCK")
                            {
                                System.Console.WriteLine("DRAW!! \n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                scorePlayer++;
                                System.Console.WriteLine("Player won!");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                scoreCPU++;
                                System.Console.WriteLine("CPU won!");
                            }
                            break;

                        case 2:
                            inputCPU = "PAPER";
                            System.Console.WriteLine("Computer chose Paper\n");

                            if (inputPlayer == "ROCK")
                            {
                                scoreCPU++;
                                System.Console.WriteLine("CPU wins!! \n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                System.Console.WriteLine("DRAW!!");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                scorePlayer++;
                                System.Console.WriteLine("Player won!");
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            System.Console.WriteLine("Computer chose Scissors\n");

                            if (inputPlayer == "ROCK")
                            {
                                scorePlayer++;
                                System.Console.WriteLine("Player wins!! \n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                scoreCPU++;
                                System.Console.WriteLine("CPU wins!!");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                System.Console.WriteLine("DRAW !!");
                            }
                            break;
                        default:
                            Console.WriteLine($" {inputPlayer} is an Incorrect entry");
                            break;

                    }

                    Console.WriteLine($"\n Final score: Player:\t {scorePlayer} CPU:\t {scoreCPU} ");

                }

                if (scorePlayer == 3) { Console.WriteLine("Player won!!"); }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU won!!");
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
            }

        }

    }

}

