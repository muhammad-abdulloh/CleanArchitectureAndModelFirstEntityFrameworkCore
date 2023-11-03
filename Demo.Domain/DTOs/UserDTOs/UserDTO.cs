using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.DTOs.UserDTOs
{
    public class UserDTO
    {
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
        public int Age { get; set; }
    }
}
