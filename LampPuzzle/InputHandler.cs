using System;

namespace LampPuzzle
{
    public class InputHandler
    {
        public static int ReadInput()
        {
            int input = 0;
            bool validInput = false;

            do
            {
                validInput = Int32.TryParse(Console.ReadLine(), out input);

                if (validInput)
                {
                    if (input != 1 && input != 2 && input != 3)
                    {
                        validInput = false;
                    }
                }

                if (!validInput)
                    Console.WriteLine("Invalid input");
            }
            while (!validInput);

            return input;
        }
    }
}