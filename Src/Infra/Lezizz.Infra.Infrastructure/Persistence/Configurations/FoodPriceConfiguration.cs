using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Lezizz.Core.Domain.Entities;

namespace Lezizz.Infra.Infrastructure.Persistence.Configurations
{
    public class FoodPriceConfiguration : IEntityTypeConfiguration<FoodPrice>
    {
        public void Configure(EntityTypeBuilder<FoodPrice> builder)
        {
            builder.Property(t => t.Price)
                .IsRequired();

            builder.ToTable(nameof(FoodPrice), "LZZ");
        }
    }
}
