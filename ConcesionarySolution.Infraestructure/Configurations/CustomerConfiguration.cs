using ConcesionarySolution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcesionarySolution.Infraestructure.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers")
                .HasKey(x => x.CustomerId);

            builder.Property(p => p.CustomerId)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(t => t.Name)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(9);
                  
        }
    }
}
