using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Configurations
{
    public class CarTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Id)
                .UseIdentityColumn();
            builder.Property(x=>x.Name).IsRequired();
            builder.HasQueryFilter(x => x.IsDeleted == false);
        }
    }
}
