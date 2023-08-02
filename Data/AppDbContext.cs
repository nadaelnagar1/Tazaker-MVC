using Microsoft.EntityFrameworkCore;
using Tazaker.Models;

namespace Tazaker.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movies> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        //cart
        public  DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options ):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movies>().HasKey(a => new
            {
                a.ActorId,
                a.MovieId
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
