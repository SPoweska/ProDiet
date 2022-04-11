using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Data.Models;
using ProDiet.Models;

namespace ProDiet.Data.Configuration
{
    public class InterviewConfiguration : IEntityTypeConfiguration<Interview>
    {



        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.HasKey(x => x.InterviewId);
            builder.ToTable("Interview");
        }
    }
}
