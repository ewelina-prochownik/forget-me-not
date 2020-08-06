using System.Data.Entity;
using ForgetMeNot.DAL.Model;

namespace ForgetMeNot.DAL
{
    public class EfCoreContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Chore> Chores { get; set; }
    }
}