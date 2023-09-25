using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesees
{
    //Create a class called Player.

   
    
    public class Player
    {
        //Create an automatic property called Health of integer type.

        //Create another property called GamerTag, with an automatic getter, of string type.

       public int Health {  get; set; }
       public string GamerTag { get; set; }


        //Create a constructor that takes one int parameter and one string parameter.
        public Player(int health, string gamerTag)
        {
            //Assign the parameters to the corresponding properties in the constructor.
            Health = health;
            GamerTag = gamerTag;
        }






        //Create a public method called JoinGame, that takes two parameters.
        // One of type Game and one of type Queue<Player>.
       
        public void JoinGame(Game game, Queue<Player> player)
        {
            //If the game's current players is equal to the max players, then add 'this' player to the queue
            //Else, print, "Joining Game" and increase current players by 1.
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                player.Enqueue(this);
            }
            else
            {
                game.CurrentPlayers++;
                Console.WriteLine("Joining Game");
            }
        }

        //Override the ToString method and return GamerTag.
        public override string ToString() { return GamerTag; }
        


       


        
    }
}
