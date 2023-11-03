using Demo.Application.Repositories;
using Demo.Domain.DTOs.UserDTOs;
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

        public async ValueTask<bool> CreateAsync(UserDTO userDTO)
        {
            try
            {
                bool result =  await _demoRepo.CreateAsync(userDTO);

                return result;

            } catch (Exception ex)
            {
                return false;
            }
        }

        public ValueTask<bool> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
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
            catch
            {
                return Enumerable.Empty<User>();
            }
        }

        public ValueTask<User> GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateAsync(UpdateDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
