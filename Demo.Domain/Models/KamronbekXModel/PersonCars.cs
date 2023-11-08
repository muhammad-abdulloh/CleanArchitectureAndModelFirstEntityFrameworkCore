using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Domain.Models.KamronbekXModel
{
    public class PersonCars
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int CarId { get; set; }


        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }

        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }

    }
}
