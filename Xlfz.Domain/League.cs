using System;
using System.ComponentModel.DataAnnotations;

namespace Xlfz.Domain
{
    public class League
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
