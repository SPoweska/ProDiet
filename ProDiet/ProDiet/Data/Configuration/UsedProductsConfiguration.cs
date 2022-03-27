using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Models;

namespace ProDiet.Data.Configuration
{
    public class UsedProductsConfiguration : IEntityTypeConfiguration<UsedProduct>
    {
        public void Configure(EntityTypeBuilder<UsedProduct> builder)
        {
            builder.HasKey(x => x.UsedProductId);
            builder.ToTable("UsedProduct");
            builder.HasOne(x => x.Dish)
                .WithMany(x => x.UsedProducts).HasForeignKey(x => x.DishId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
