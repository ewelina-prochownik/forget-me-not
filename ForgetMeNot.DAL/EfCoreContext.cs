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
    }
}