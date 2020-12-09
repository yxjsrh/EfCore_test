using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Xlfz.Domain
{
    /// <summary>
    /// 足球队
    /// </summary>
    public class Club
    {
        public Club()
        {
            Players = new List<Player>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfEstablishment { get; set; }
        public string History { get; set; }
        public int LeagueId { get;set;}
        //导航属性 ，导航到一个league中  每一个club都对应一个league  而每个club对应的league可能是同一个，所以说一个league可能对应多个club   表明了多对1的关系
        public League League { get;set;}

        //导航属性  另一个形式  1对多的关系 1个club包含多个player
        public List<Player> Players { get; set; }
    }
}
