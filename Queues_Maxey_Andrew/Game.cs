using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Maxey_Andrew
{
    internal class Game
    {
        public int MaxPlayer { get; }

        public int CurrentPlayers { get; set; }

        public Game(int maxP, int currentP)
        {
            MaxPlayer = maxP;
            CurrentPlayers = currentP;
        }

        public void KickPlayer()
        {
            CurrentPlayers--;
        }
        public void CheckQueue(Queue<Player> playerQueue)
        {
            if(CurrentPlayers < MaxPlayer)
            {
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
            else
            { Console.WriteLine("No room to join, try again later.");
            }
        }
    }
}
