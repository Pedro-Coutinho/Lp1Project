using System;

namespace LampPuzzle
{
    public class InputHandler
    {
        /// <summary>
        /// Method that verify input given by the user
        /// Check it to see if is valid, if not, print that information
        /// </summary>
        /// <returns></returns> input
        public static int ReadInput()
        {
            int input = 0;
            bool validInput = false;

            do
            {
                validInput = Int32.TryParse(Console.ReadLine(), out input);

                if (validInput)//if input is valid
                {
                    if (input != 1 && input != 2 && input != 3)//condition check
                    {
                        validInput = false;//input isn't: 1,2,3; input isn't valid
                    }
                }

                if (!validInput)//if input is not valid
                    Console.WriteLine("Invalid input");
            }
            while (!validInput);

            return input;
        }
    }
}