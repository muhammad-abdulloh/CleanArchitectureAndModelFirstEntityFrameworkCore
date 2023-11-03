using Demo.Domain.DTOs.UserDTOs;
using Demo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Repositories
{
    public interface IDemoRepository
    {
        public ValueTask<IEnumerable<User>> GetAllUsersAsync();

        public ValueTask<User> GetByIdAsync();
        public ValueTask<bool> CreateAsync(UserDTO userDTO);
        public ValueTask<bool> UpdateAsync(UpdateDTO user);
        public ValueTask<bool> DeleteAsync(int Id);
    }


}
