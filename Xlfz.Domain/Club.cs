﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xlfz.Domain
{
    public class Club
    {
        public Club()
        {
            Players = new List<Player>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime DateOfEstablishment { get; set; }
        public string History { get; set; }
        public int LeagueId { get;set;}
        public League League { get;set;}

        public List<Player> Players { get; set; }
    }
}
