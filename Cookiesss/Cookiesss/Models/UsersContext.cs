using System.Data.Entity;

namespace Cookiesss.Models
{
    public class UsersContext:DbContext
    {
        public UsersContext():base("CrudConnection")
        {
            Database.SetInitializer<UsersContext>(null);
        }

        public DbSet<AppUsers> AppUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUsers>()
                .Property(a => a.Name)
                .IsRequired();

            modelBuilder.Entity<AppUsers>()
                .Property(a => a.UserName)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}