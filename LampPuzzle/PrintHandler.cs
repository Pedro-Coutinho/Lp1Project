using System;
using System.Text;

namespace LampPuzzle
{
    public class PrintHandler
    {
        public static void PrintLamps(bool[] lamps)
        {
            //Instantiate String Builder
            string output = "";

            //Cycle through lamps
            for (int i = 0; i < lamps.Length; i++)
            {
                //Add full square if lamp is on
                if (lamps[i])
                    output+= "True ";
                else
                    output+= "False ";
            }

            //Print the output
            Console.WriteLine(output);
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