using System;
using System.ComponentModel.DataAnnotations;


/// <summary>
/// 导入 System.ComponentModel.DataAnnotations; 限值属性
/// </summary>
namespace Xlfz.Domain
{

    /// <summary>
    /// 联赛
    /// </summary>
    public class League
    {
        public int Id { get; set; }
        [MaxLength(100),Required]
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
