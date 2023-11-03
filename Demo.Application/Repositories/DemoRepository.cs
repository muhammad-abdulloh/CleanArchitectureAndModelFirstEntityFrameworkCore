using Demo.Application.DataAcsess;
using Demo.Domain.BaseModels.Enums;
using Demo.Domain.DTOs.UserDTOs;
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

        public async ValueTask<bool> CreateAsync(UserDTO userDTO)
        {
            try
            {
                User user = new User()
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    Age = userDTO.Age,
                    Password = userDTO.Password,
                };

                await _dbContext.Users.AddAsync(user);
                int x =  await _dbContext.SaveChangesAsync();

                return x > 0;
            }
            catch (Exception ex)
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
            IEnumerable<User> users = (IEnumerable<User>)await _dbContext.Users.ToListAsync();

            return users;
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
