using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Models;

namespace ProDiet.Data.Configuration
{
    public class BodyMeasurementConfiguration : IEntityTypeConfiguration<BodyMeasurement>
    {
        public void Configure(EntityTypeBuilder<BodyMeasurement> builder)
        {
            builder.HasKey(x => x.MeasurementId);
            builder.ToTable("BodyMeasurement");
            builder.HasOne(x => x.Patient)
                .WithMany(x => x.BodyMeasurements).HasForeignKey(x => x.PatientId).OnDelete(DeleteBehavior.Cascade);
        }


    }
}
