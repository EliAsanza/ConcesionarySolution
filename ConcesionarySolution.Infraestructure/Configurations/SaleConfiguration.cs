using ConcesionarySolution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcesionarySolution.Infraestructure.Configurations
{
    internal class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("sales")
                .HasKey(x => x.SaleId);

            builder.Property(p => p.SaleId)
                .ValueGeneratedOnAdd()
                .IsRequired();
                      
        }
    }
}
