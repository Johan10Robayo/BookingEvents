using Booking_Events_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection;

namespace Booking_Events_API.Infrastructure.Persistence
{
    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Conventions.Remove(typeof(CascadeDeleteConvention));
        }

        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Venue> Venues => Set<Venue>();
        public DbSet<Event> Events => Set<Event>();
        public DbSet<Section> Sections => Set<Section>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<RoleUser> RoleUsers => Set<RoleUser>();
        public DbSet<User> User => Set<User>();
        public DbSet<Discount> Discounts => Set<Discount>();
        public DbSet<Purchase> Purchases => Set<Purchase>();

    }
}
