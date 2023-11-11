using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Domain.Models.KamronbekXModel
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<PersonCars> CarPersons { get; set; }
    }
}
