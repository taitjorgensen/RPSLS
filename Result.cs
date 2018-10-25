using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Result
    {
        //member variable
        public Game game;


        //constructor


        //member method
        private string GetPlayerGestures(string playerOneGesture, string playerTwoGesture)
        {
            
        }
        public string DetermineRoundWinner()
        {
            if ("rock", "scissors")
            {
                Console.WriteLine(string roundWinner + "\'s rock crushes scissors!");
            }
            else if ("scissors", "paper")
            {
                Console.WriteLine(string roundWinner + "\'s scissors cuts through paper!");
            }
            else if ("paper", "rock")
            {
                Console.WriteLine(string roundWinner + "\'s paper covers rock.");
            }
            else if ("lizard", "spock")
            {
                Console.WriteLine(string roundWinner + "\'s lizard has poisoned Spock!");
            }
            else if ("spock", "scissors")
            {
                Console.WriteLine(string roundWinner + "\'s Spock is like a rock and smashed scissors.");
            }
            else if ("scissors", "lizard")
            {
                Console.WriteLine(string roundWinner + "\'s scissors have decapitated the lizard!");
            }
            else if ("lizard", "paper")
            {
                Console.WriteLine(string roundWinner + "\'s lizard was hungry and ate the paper.");
            }
            else if ("paper", "spock")
            {
                Console.WriteLine(string roundWinner + "\'s paper has disproven Spock.");
            }
            else if ("spock", "rock")
            {
                Console.WriteLine(string roundWinner + "\'s Spock vaporized the rock.");
            }
            else{
                Console.WriteLine("This round ended in a draw");
            }
        }
    }
}
