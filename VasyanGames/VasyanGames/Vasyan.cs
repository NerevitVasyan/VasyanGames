namespace VasyanGames
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Vasyan : DbContext
    {
       
        public Vasyan()
            : base("name=Vasyan")
        {
        }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}