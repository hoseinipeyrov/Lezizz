using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Lezizz.Core.Domain.Entities;

namespace Lezizz.Infra.Infrastructure.Persistence.Configurations
{
    public class FoodImageConfiguration : IEntityTypeConfiguration<FoodImage>
    {
        public void Configure(EntityTypeBuilder<FoodImage> builder)
        {
            builder.Property(t => t.ImagePath)
                .HasMaxLength(256)
                .IsRequired();

            builder.ToTable(nameof(FoodImage), "LZZ");
        }
    }
}
