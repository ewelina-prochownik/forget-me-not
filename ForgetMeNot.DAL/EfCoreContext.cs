using ForgetMeNot.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace ForgetMeNot.DAL
{
    public class EfCoreContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<CompletedChore> CompletedChores { get; set; }

        public EfCoreContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-UP96HRP\SQLEXPRESS;Initial Catalog=ForgetMeNot;Integrated Security=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CompletedChore>()
                .HasOne(f => f.Plant)
                .WithMany(x => x.CompletedChores)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Chore>().HasMany(x => x.CompletedChores)
                .WithOne(x => x.Chore)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Plant>().HasMany(x => x.Chores)
                .WithOne(x => x.Plant).OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Plant>().HasMany(x => x.CompletedChores)
                .WithOne(x => x.Plant).OnDelete(DeleteBehavior.NoAction);
        }
    }
}