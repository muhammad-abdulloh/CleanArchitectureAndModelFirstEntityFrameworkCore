using Demo.Application.Configurations;
using Demo.Domain.Models;
using Demo.Domain.Models.KamronbekXModel;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Demo.Application.DataAcsess
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetCallingAssembly());

            //alohida berish ham mumkin
            //modelBuilder.ApplyConfiguration(new CarTypeConfiguration());
        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<KamronbekX> KamronbekXes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<PersonCars> PersonCars { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}
