using Demo.Domain.Models.KamronbekXModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Domain.Configurations
{
    public class OrderTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .HasDefaultValue("burger")
                .IsRequired(false);

            builder.HasOne(x => x.Person)
                .WithMany(y => y.Orders)
                .HasForeignKey(x=>x.PersonId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);
        }
    }
}
