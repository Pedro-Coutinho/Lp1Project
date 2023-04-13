using System;

namespace LampPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] lampStatus = new bool[3];
            bool victory = false;
            int lampsOn = 0;

            int input = 0;

            PrintLamps(lampStatus);

            for (int i = 0; i < 6; i++)
            {
                Int32.TryParse(Console.ReadLine(), out input);
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
                
                PrintLamps(lampStatus);
                
                foreach(bool lamp in lampStatus)
                {
                    if(lamp)
                        lampsOn++; 
                }

                if (lampsOn == 3)
                    victory = true;
                else
                    lampsOn = 0;
            }

            if(victory)
                Console.WriteLine("You Win!");
            else
                Console.WriteLine("You Lose!");
        }

        static void PrintLamps(bool[] lamps)
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
    }
}
