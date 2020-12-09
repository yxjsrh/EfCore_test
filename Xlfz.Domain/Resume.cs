using System;
using System.Collections.Generic;
using System.Text;

namespace Xlfz.Domain
{
    //简历
    public class Resume
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int PlayerId { get; set; }  //设置1对1 关系
        public Player Player { get; set; }

    }
}
