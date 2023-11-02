using Demo.Application.DataAcsess;
using Demo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Repositories
{
    public class DemoRepository : IDemoRepository
    {
        public readonly DemoDbContext _dbContext;

        public DemoRepository(DemoDbContext context)
        {
            _dbContext = context;
        }

        public async ValueTask<IEnumerable<User>> GetAllUsersAsync()
        {
            IEnumerable<User> users = await _dbContext.Users.ToListAsync();

            return users;
        }
    }
}
