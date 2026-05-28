using System;
using System.Collections.Generic;
using System.Globalization;


namespace NaughtsAndCrosses
{
    class MainClass
    {
        //creates bord
        static void bordDisplay(int xpos, int ypos, char UserAvatar)
        {
            int tempCounter = 0;
            char[,] bord = new char[19,19];

            //colums
            for (int i = 0; i < 19; i++)
            {
                if (i == 4 || i == 9 || i == 14)
                {
                    for (int k = 0; k < 19; k++)
                    {
                        
                        bord[i, k] = '|';
                    }
                }
                else
                {
                    for (int k = 0; k < 19; k++)
                    {

                        bord[i, k] = ' ';

                    }
                }
            }

            //rows
            for (int i = 0; i < 19; i++)
            {
                if (i == 4 || i == 9 || i == 14)
                {
                    for (int k = 0; k < 19; k++)
                    {

                        bord[k,i] = '-';

                    }
                }
                else
                {
                    for (int k = 0; k < 19; k++)
                    {

                        bord[k,i] = ' ';
                    }
                }
            }

            bord[ypos, xpos] = UserAvatar;

            //displays bord

            while (tempCounter != 19)
            {
                for (int i = 0; i < 19; i++)
                {
                    Console.Write(bord[tempCounter, i]);
                    Console.Write(bord[i, tempCounter]);
                }

                Console.Write("\n");
                tempCounter += 1;
            }


        }


        public static void Main(string[] args)
        {
            char userAvatar = ' ';
            int numBox;
            int xpos;
            int ypos;
            List<string> usedBoxes = new List<string>();
            int[] posToPutSymbol = {1,2, 6,2, 11,2, 16,2,
                1,7, 6,7,11,7,16,7,
            1,12, 6,12,11,12,16,12,
            1,17, 6,17,11,17,16,17};
            
            Console.WriteLine("Welcome to naughts and crosses, select either naughts or crosses by typing 'N' or 'C'");
            userAvatar = Convert.ToChar(Console.ReadLine());

            //get user to pick a position to place their naught or cross
            Console.WriteLine("Select a box between 1 and 16 to place your symbol");
            numBox = Convert.ToInt32(Console.ReadLine());

            xpos = posToPutSymbol[(numBox * 2) - 1];
            ypos = posToPutSymbol[(numBox * 2)];


            bordDisplay(xpos, ypos, userAvatar);

            Console.Read();
        }
    }
}
