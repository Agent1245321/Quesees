using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Quesees
{
    //Create a class called Game.

  

   

   


  


   
    public class Game
    {
        // Create a property called, MaxPlayers with an automatic getter.

        //Create a property called, CurrentPlayers with an automatic getter and setter.
        public int MaxPlayers { get; set; }
        public int CurrentPlayers { get; set; }

        // Create a constructor that takes two int parameters, maxPlayers and currentPlayers.
        public Game(int maxPlayers, int currentPlayers)
        {
            // Assign the parameters to the corresponding properties in the constructor.
            MaxPlayers = maxPlayers;
            CurrentPlayers = currentPlayers;
        }


        // Create a method called, KickPlayer.In the body decrement CurrentPlayers by 1.
        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        // Create a method called, CheckQueue, that takes a Queue<Player> parameter.

        //  In the body, if CurrentPlayers is less than MaxPlayers, then check if the queue has elements in it.

        // If the queue has players in it, call Dequeue on the queue and increment current players by 1. Else, print, "No Players in the Queue!".
        public void CheckQueue(Queue<Player> players) 
        {
            int check = 0;
            if (CurrentPlayers < MaxPlayers) {check  = players.Count; }
            if (check > 0) { players.Dequeue(); CurrentPlayers++; }
            else
            {
                Console.WriteLine("No Players in the Queue!");
            }
        }
    }
}
