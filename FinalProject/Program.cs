using System;

namespace FinalProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Control newBoard = new Control();
            Console.WriteLine("TEST");
            //Console.WriteLine("Name Player 1: ");
            //newBoard.Player1name = Console.ReadLine();
            //Console.WriteLine("Name Player 2: ");
            //newBoard.Player2name = Console.ReadLine();

            newBoard.autoPopulateBoard();
            string ans;
             do
            {
                //Console.WriteLine($"Conect 4 Game. {newBoard.Player1name} Vs {newBoard.Player2name}");
                Console.WriteLine($"Conect 4 Game.");
 
                 newBoard.displayBoard();


                ans = Console.ReadLine();
                if(ans == "f")
                {
                    break;

                }

                
                
                
            } while (true) ;
        }
    }
}
