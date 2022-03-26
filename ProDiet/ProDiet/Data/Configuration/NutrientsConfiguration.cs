using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Data.Models;

namespace ProDiet.Data.Configuration
{
    public class NutrientsConfiguration : IEntityTypeConfiguration<Nutrient>
    {
        public void Configure(EntityTypeBuilder<Nutrient> builder)
        {
            builder.HasKey(x => x.NutrientId);
            builder.ToTable("Nutrients");
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Nutrients).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
