using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //member variable
        public int score = 0;
        public Player playerOne;
        public Player playerTwo;

        //constructor
        public Player(string playerName, int score)
        {

        }


        //member method
        public Player CreatePlayers()
        {
            if (game.numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (game.numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else if (game.numberOfPlayers == 0)
            {
                playerOne = new Computer();
                playerTwo = new Computer();
            }
            else
        }
        public abstract string GetGesture()
        {
            Console.WriteLine("Please choose your gesture:");
            Console.ReadLine();
            return playerGesture;
        }

    }
}
