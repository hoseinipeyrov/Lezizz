using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Lezizz.Core.Domain.Entities;

namespace Lezizz.Infra.Infrastructure.Persistence.Configurations
{
    public class PosConfiguration : IEntityTypeConfiguration<Pos>
    {
        public void Configure(EntityTypeBuilder<Pos> builder)
        {
            builder.Property(t => t.PersianName)
                .HasMaxLength(200)
                .IsRequired();

            builder.ToTable(nameof(Pos), "LZZ");
        }
    }
}
