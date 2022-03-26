using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Data.Models;
using ProDiet.Models;

namespace ProDiet.Data.Configuration
{
    public class HomeMeasurementConfiguration : IEntityTypeConfiguration<HomeMeasurement>
    {
        public void Configure(EntityTypeBuilder<HomeMeasurement> builder)
        {
            builder.HasKey(x => x.MeasurementId);
            builder.ToTable("HomeMeasurement");
            builder.HasOne(x => x.Product)
                .WithMany(x => x.HomeMeasurement).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
