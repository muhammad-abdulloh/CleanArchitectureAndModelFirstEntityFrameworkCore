using Demo.Domain.Models;
using Demo.Domain.Models.SarvarXModel;
using Microsoft.EntityFrameworkCore;

namespace Demo.Application.DataAcsess
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<SarvarX> SarvarX { get; set;}
    }
}
