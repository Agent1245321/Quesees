// See https://aka.ms/new-console-template for more information

//In Program.cs, create a Game object and set its max players to 50 and current players to 49.
using Quesees;

Game apex = new Game(50, 49);
//Create a Queue of Player objects.
Queue<Player> waitingList = new Queue<Player>();
//Create 4 Player objects, giving them 100 health and a unique gamer tag.
Player player = new Player(100, "Agent1245321");
Player player2 = new Player(100, "N7_Dalton");
Player player3 = new Player(100, "HighQualityDuck");
Player player4 = new Player(100, "FearedOutlaw");
//Call JoinGame on all 4 player objects; passing through the game and queue as arguments.
player.JoinGame(apex, waitingList);
player2.JoinGame(apex, waitingList);
player3.JoinGame(apex, waitingList);
player4.JoinGame(apex, waitingList);
//Print, "Players in Queue" to console.
Console.WriteLine("Players in Queue");
//Loop through the queue and print all the players on a new line.
foreach (Player p in waitingList) 
{
    Console.WriteLine(p.ToString());
}
//Call KickPlayer on the game.
apex.KickPlayer();
//Call CheckQueue on the game.
apex.CheckQueue(waitingList);
//Then print, "\nPlayers in Queue" to console.
Console.WriteLine("\n" + "Players in Queue");
//Loop through the queue and print all the players on a new line.
foreach (Player p in waitingList)
{
    Console.WriteLine($"The player {p.ToString()} is waiting");
}