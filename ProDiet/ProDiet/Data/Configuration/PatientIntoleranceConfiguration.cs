using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Models;

namespace ProDiet.Data.Configuration
{
    public class PatientIntoleranceConfiguration : IEntityTypeConfiguration<PatientIntolerance>
    {
        public void Configure(EntityTypeBuilder<PatientIntolerance> builder)
        {
            builder.HasKey(x => x.IntoleranceId);
            builder.ToTable("PatientIntolerance");
            builder.HasOne(x => x.Patient)
                .WithMany(x => x.PatientIntolerances).HasForeignKey(x => x.PatientId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
