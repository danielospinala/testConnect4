using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class BoardConnect4
    {
        //public Player Player1 { get; set; }
        //public Player Player2 { get; set; }
        public char[,] Board { get; set; }
        public BoardConnect4()
        {
            
            Board = new char[6, 7];
        }
        public void autoPopulateBoard()
        {
            for(int i = 0; i<6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Board[i, j] = 'X';
                }
                
            }
        }
        public void displayBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write(" | ");
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(Board[i, j]);
                    Console.Write(' ');
                }
                Console.Write("| ");
                Console.WriteLine();

            }
            Console.WriteLine(" | 1 2 3 4 5 6 7 |");


        }
        public bool winner()
        {
            bool w = false;
            

            return w;
        }

    }
}
