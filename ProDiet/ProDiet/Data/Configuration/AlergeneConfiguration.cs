using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Data.Models;

namespace ProDiet.Data.Configuration
{
    public class AlergeneConfiguration : IEntityTypeConfiguration<Alergene>
    {
        public void Configure(EntityTypeBuilder<Alergene> builder)
        {
            builder.HasKey(x => x.AlergeneId);
            builder.ToTable("Alergene");
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Alergenes).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
