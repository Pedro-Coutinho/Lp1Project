using System.Linq;

namespace LampPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] lampStatus = new bool[3];
            bool victory = false;
            int winingMoves = 0;

            int input = 0;

            
            PrintHandler.PrintRules();
            PrintHandler.PrintLamps(lampStatus);

            for (int i = 0; i < 6; i++)
            {
                PrintHandler.PrintRound(i);
                input = InputHandler.ReadInput();
                bool tempLamp = false;
                switch (input)
                {
                    case 1:
                        lampStatus[0] = !lampStatus[0];
                        break;
                    case 2:
                        tempLamp = lampStatus[0];
                        lampStatus[0] = lampStatus[1];
                        lampStatus[1] = tempLamp;
                        break;
                    case 3:
                        tempLamp = lampStatus[1];
                        lampStatus[1] = lampStatus[2];
                        lampStatus[2] = tempLamp;
                        break;

                }
                
                PrintHandler.PrintLamps(lampStatus);

                if (lampStatus.All(x => x))
                {
                    victory = true;
                    winingMoves = i + 1;
                    break;
                }

            }

            PrintHandler.Resolution(victory, winingMoves);
        }

    }
}
