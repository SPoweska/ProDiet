using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Models;

namespace ProDiet.Data.Configuration
{
    public class InterviewConfiguration : IEntityTypeConfiguration<Interview>
    {



        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Interview");
            builder.HasOne(x => x.Patient)
                .WithMany(x => x.Interview).HasForeignKey(x => x.PatientId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
