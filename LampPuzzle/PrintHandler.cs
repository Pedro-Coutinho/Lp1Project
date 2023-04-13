using System;
using System.Text;

namespace LampPuzzle
{
    public class PrintHandler
    {
        public static void PrintRules()
        {
            Console.WriteLine("Welcome to the Lamp Puzzle!");
            Console.WriteLine("You have 6 moves to turn all the lamps on!");
            Console.WriteLine("You have 3 buttons, 1, 2 and 3.");
            Console.WriteLine("Press 1, 2 and 3 to click on the respective button");
            Console.WriteLine("");
            Console.WriteLine("Press Enter when you're ready to start!");
            Console.ReadLine();
        }

        public static void PrintLamps(bool[] lamps)
        {
            //Instantiate String Builder
            StringBuilder output = new StringBuilder();

            //Cycle through lamps
            for (int i = 0; i < lamps.Length; i++)
            {

                //Check if it isn't the first lamp
                if (i != 0)
                    //Append the hyphen
                    output.Append("  ");

                //Add full square if lamp is on
                if (lamps[i])
                    output.Append("|\u25A0|");
                else
                    output.Append("| |");

            }

            //Print the output
            Console.WriteLine(output.ToString());
            Console.WriteLine("|1|  |2|  |3|");
            Console.WriteLine("");
        }

        public static void PrintRound(int roundN)
        {
            roundN++;
            Console.WriteLine($"Round {roundN}");
        }

        public static void Resolution(bool victory, int moves = 0)
        {
            if (victory)
                Console.WriteLine($"You won in {moves} moves!");
            else
                Console.WriteLine("You exceeded 6 moves... Try again!");
        }
    }
}