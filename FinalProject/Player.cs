using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Player
    {
        public string PlayerName { get; set; }
        public char TypeOfPlayer { get; set; }

        public Player(string name, char type)
        {
            PlayerName = name;
            TypeOfPlayer = type;
        }

    }
}
