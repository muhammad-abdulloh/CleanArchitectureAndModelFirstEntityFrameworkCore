using Demo.Domain.BaseModels.Entities;
using Demo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Application.DataAcsess
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<SalohiddinX> SalohiddinX { get; set; }
    }
}
