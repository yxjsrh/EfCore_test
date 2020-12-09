using System;
using System.Collections.Generic;
using System.Text;

namespace Xlfz.Domain
{
    public class GamePlayer
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }    //另外体现多对1的关系  两端都可以体现
        public Player Player { get; set; }

    }
}
