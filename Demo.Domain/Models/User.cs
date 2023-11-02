using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }

        [Required]
        public string Password { get; set; }
        public int Age { get; set; }

    }
}
