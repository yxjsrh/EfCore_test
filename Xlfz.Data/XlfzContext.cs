using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

using Xlfz.Domain;

namespace Xlfz.Data
{
    public class XlfzContext:DbContext
    {
        public XlfzContext(DbContextOptions<XlfzContext> options):base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseMySQL("Server=localhost;Port=2901;Database=com_test;user=PsycheArk;password=Xlfz_grouP;SslMode=None;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////设置联合主键
            modelBuilder.Entity<GamePlayer>().HasKey(x => new
            {
                x.PlayerId,
                x.GameId
            });
            ////设置1对1的主体
            modelBuilder.Entity<Resume>().HasOne(x => x.Player).WithOne(x => x.Resume).HasForeignKey<Resume>();
        }
        public DbSet<League> League { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Player> Player { get; set; }
    }
}
