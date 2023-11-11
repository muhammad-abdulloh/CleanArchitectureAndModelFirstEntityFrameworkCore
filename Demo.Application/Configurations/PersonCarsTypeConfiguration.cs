using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Configurations
{
    public class PersonCarsTypeConfiguration : IEntityTypeConfiguration<PersonCars>
    {
        public void Configure(EntityTypeBuilder<PersonCars> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Person)
                .WithMany(x => x.PersonCars)
                .HasForeignKey(x=>x.PersonId);

            builder.HasOne(x => x.Car)
                .WithMany(x => x.CarPersons)
                .HasForeignKey(x=>x.CarId);
        }
    }
}
