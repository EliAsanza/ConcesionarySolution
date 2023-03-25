using ConcesionarySolution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcesionarySolution.Infraestructure.Configurations
{
    public class RevisionConfiguration : IEntityTypeConfiguration<Revision>
    {
        public void Configure(EntityTypeBuilder<Revision> builder)
        {
            builder.ToTable("revisions")
               .HasKey(x => x.Revisionid);

            builder.Property(p => p.Revisionid)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(t => t.Quantity)
                .IsRequired();

            builder.Property(t => t.Filtro)
                .IsRequired();

            builder.Property(t => t.Oil)
                .IsRequired();

            builder.Property(t => t.Freno)
                .IsRequired();

            builder.Property(t => t.Other)
               .HasMaxLength(20);

        }
    }
}
