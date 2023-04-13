using System;
using System.Text;

namespace LampPuzzle
{
    /// <summary>
    /// This class will handle every print that the game will need,so the main 
    /// doesn't be occupied by any of these
    /// </summary>
    public class PrintHandler
    {
        /// <summary>
        /// This method will print the game rules
        /// </summary>
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

        /// <summary>
        /// Runs through all the lamps, verifying each one condition
        /// Depends on each condition it will print different things
        /// Also prints the number of the lamp to make it clear to the user
        /// </summary>
        /// <param name="lamps"></param>bools array
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
        /// <summary>
        /// This method is just to print the round number
        /// </summary>
        /// <param name="roundN"></param>number of rounds played
        public static void PrintRound(int roundN)
        {
            roundN++;
            Console.WriteLine($"Round {roundN}");
        }
        /// <summary>
        /// Verifying if victory condiction is true, if so, inform the user
        /// thats a win, and how many round was played
        /// If victory is false, inform the user thats a lose
        /// </summary>
        /// <param name="victory"></param>condition do win
        /// <param name="moves"></param>number of moves
        public static void Resolution(bool victory, int moves = 0)
        {
            if (victory)
                Console.WriteLine($"You won in {moves} moves!");
            else
                Console.WriteLine("You exceeded 6 moves... Try again!");
        }
    }
}