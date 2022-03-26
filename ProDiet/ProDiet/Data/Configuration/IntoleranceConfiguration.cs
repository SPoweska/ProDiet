using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Data.Models;
using ProDiet.Models;

namespace ProDiet.Data.Configuration
{
    public class IntoleranceConfiguration : IEntityTypeConfiguration<Intolerance>
    {
        public void Configure(EntityTypeBuilder<Intolerance> builder)
        {
            builder.HasKey(x => x.IntoleranceId);
            builder.ToTable("Intolerance");
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Intolerances).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}