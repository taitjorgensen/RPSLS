using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variable
        
        public List<string> listOfRules = { "Rock crushes Scissors\n", "Paper covers Rock\n", "Rock crushes Lizard\n", "Lizard poisons Spock\n", "Spock smashes Scissors\n", "Scissors decapitates Lizard\n", "Lizard eats Paper\n", "Paper disproves Spock\n", "Spock vaporizes Rock\n", };
        

        //constructor


        //member method
        public void DisplayRules(List<string> listOfRules)
        {
            Console.WriteLine(listOfRules);
            Console.ReadLine();
        }
        public int DetermineNumberOfPLayers()
        {
            Console.WriteLine("How many people will play? Enter 0, 1, or 2");
            int numberOfPlayers = Console.ReadLine();
            if (numberOfPlayers > 2)
            {
                Console.WriteLine("Please enter a valid number 0 - 2");
                Console.ReadLine();
                DetermineNumberOfPLayers();
            }
            else if (numberOfPlayers < 0)
            {
                Console.WriteLine("Please enter a valid number 0 - 2");
                Console.ReadLine();
                DetermineNumberOfPLayers();
            }
            else
            {

            }
            return numberOfPlayers;
        }
        public void PlayRound()
        {


        }
        public void player.GetGesture(string playerOneGesture);
        public void player.GetGesture(string playerTwoGesture);


        public void ResultOfGame(int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore == 2)
            {
                Console.WriteLine("Player One is the winner!");
                Console.ReadLine();
            }
            else if (playerTwoScore == 2)
            {
                Console.WriteLine("Player Two is the winner!");
                Console.ReadLine();
            }
            else
            {
                Game.PlayRound();
            }
        }
    }
}
