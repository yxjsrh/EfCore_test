﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xlfz.Domain
{
    public class Player
    {
        public Player()
        {
            GamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public int ClubId { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }//做了其对中间表的1对多关系

        public int ResumeId { get; set; }
        public Resume Resume { get; set; }

    }
}
