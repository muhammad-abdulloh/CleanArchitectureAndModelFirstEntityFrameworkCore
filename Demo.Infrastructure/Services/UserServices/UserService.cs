using Demo.Application.Repositories;
using Demo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Services.UserServices
{
    public class UserService : IUserService
    {
        private IDemoRepository _demoRepo;
        public UserService(IDemoRepository demoRepository)
        {
            _demoRepo = demoRepository;
        }
        public async ValueTask<IEnumerable<User>> GetAllUsersAsync()
        {
            try
            {
                IEnumerable<User> users = await _demoRepo.GetAllUsersAsync();

                if (users is not null)
                {
                    return users;
                }

                return Enumerable.Empty<User>();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<User>();
            }
        }
    }
}
