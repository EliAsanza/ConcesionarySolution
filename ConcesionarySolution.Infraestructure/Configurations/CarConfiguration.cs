using ConcesionarySolution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcesionarySolution.Infraestructure.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("cars")
                .HasKey(x => x.CarId);

            builder.Property(p => p.CarId)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(t => t.LicensePlate)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(t => t.Brand)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(t => t.Model)
                .HasMaxLength(100);

            builder.Property(t => t.Color)
                .HasMaxLength(100);

            builder.Property(t => t.Price)
                .IsRequired();
        }
    }
}