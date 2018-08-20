namespace VasyanGames
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Vasyan : DbContext
    {
       
        public Vasyan()
            : base("name=VasyanString")
        {
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
    }
}