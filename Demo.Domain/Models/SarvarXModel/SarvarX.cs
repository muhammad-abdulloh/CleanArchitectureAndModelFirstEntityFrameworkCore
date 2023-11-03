using Demo.Domain.BaseModels.Entities;

namespace Demo.Domain.Models.SarvarXModel
{
    public class SarvarX : BaseEntity
    { 
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
