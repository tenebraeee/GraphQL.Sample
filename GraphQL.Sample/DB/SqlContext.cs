using GraphQL.Sample.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Sample.DB
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>(e => 
            {
                e.HasMany(b => b.Rooms)
                 .WithOne(r => r.Building)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Room>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
