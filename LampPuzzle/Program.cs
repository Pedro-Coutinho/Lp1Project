using System.Linq;

namespace LampPuzzle
{
    /// <summary>
    /// Main Class
    /// </summary>
    class Program
    {   
        /// <summary>
        /// Main Class of the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Bool array to store the status of the lamps
            bool[] lampStatus = new bool[3];

            //Bool for victory condition
            bool victory = false;

            //Int to store the number of moves used
            int winingMoves = 0;
            
            //Int to store the input of the player
            int input = 0;

            //Prints rules
            PrintHandler.PrintRules();

            //Prints the first status of the Lamps (All off/false)
            PrintHandler.PrintLamps(lampStatus);

            //Cycles for 6 turns
            for (int i = 0; i < 6; i++)
            {   
                //Prints the round number/move number
                PrintHandler.PrintRound(i);

                //Gets the player Input
                input = InputHandler.ReadInput();

                //Create temp bool to store the status of a lamp
                bool tempLamp = false;

                //Switch for each button
                switch (input)
                {
                    //Button 1
                    case 1:
                        //Inverts lamp 1
                        lampStatus[0] = !lampStatus[0];
                        break;
                    //Button 2
                    case 2:
                        //Store the value of lamp 1 on the tempLamp
                        tempLamp = lampStatus[0];
                        //Assigns the value of lamp 2 to lamp 1
                        lampStatus[0] = lampStatus[1];
                        //Assigns the value of lamp 1 to lamp 2
                        lampStatus[1] = tempLamp;
                        break;
                    //Button 3
                    case 3:
                        //Store the value of lamp 2 on the tempLamp
                        tempLamp = lampStatus[1];
                        //Assigns the value of lamp 3 to lamp 2
                        lampStatus[1] = lampStatus[2];
                        //Assigns the value of lamp 2 to lamp 3
                        lampStatus[2] = tempLamp;
                        break;

                }
                
                //Prints the status of the lamps
                PrintHandler.PrintLamps(lampStatus);

                //Uses linq to check if all lamps are on/true
                if (lampStatus.All(x => x))
                {   
                    //Set winning condition to true
                    victory = true;
                    //Stores the number of moves made
                    winingMoves = i + 1;
                    //gets out of the for if player wins before 6 moves
                    break;
                }

            }

            //Prints the game resolution (Win or False)
            PrintHandler.Resolution(victory, winingMoves);
        }

    }
}
