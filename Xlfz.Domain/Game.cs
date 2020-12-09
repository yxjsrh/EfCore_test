using System;
using System.Collections.Generic;
using System.Text;

namespace Xlfz.Domain
{
    public class Game
    {
        public Game()
        {
            GamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
        public int Round { get; set; }  //比赛的第几轮
        public DateTimeOffset?  StartTime { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }

    }
}
