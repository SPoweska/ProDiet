using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Models;

namespace ProDiet.Data.Configuration
{
    public class PatientAlergeneConfiguration : IEntityTypeConfiguration<PatientAlergene>
    {
        public void Configure(EntityTypeBuilder<PatientAlergene> builder)
        {
            builder.HasKey(x => x.AlergeneId);
            builder.ToTable("PatientAlergene");
            builder.HasOne(x => x.Patient)
                .WithMany(x => x.PatientAlergenes).HasForeignKey(x => x.PatientId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
