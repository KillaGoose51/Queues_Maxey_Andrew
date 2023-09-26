using System.Collections.Generic;

namespace Queues_Maxey_Andrew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            Queue<Player> waitingtoJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "MMSix");
            Player p2 = new Player(100, "xXAwesomenessXx");
            Player p3 = new Player(100, "Get Good");
            Player p4 = new Player(100, "ZombieSlaya");

            p1.JoinGame(myGame, waitingtoJoinQ);
            p2.JoinGame(myGame, waitingtoJoinQ);
            p3.JoinGame(myGame, waitingtoJoinQ);
            p4.JoinGame(myGame, waitingtoJoinQ);

            Console.WriteLine("Players in da Q:");
            foreach(Player player in waitingtoJoinQ)
            {
                Console.WriteLine(player);
            }

            myGame.KickPlayer();
            myGame.CheckQueue(waitingtoJoinQ);

            Console.WriteLine("\nPlayers in da Q:");
            foreach (Player player in waitingtoJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}