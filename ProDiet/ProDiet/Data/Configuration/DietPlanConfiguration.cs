using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Models.DietPlan;

namespace ProDiet.Data.Configuration
{
    public class DietPlanConfiguration : IEntityTypeConfiguration<DietPlanDay>
    {
        public void Configure(EntityTypeBuilder<DietPlanDay> builder)
        {
            builder.HasKey(x => x.DietPlanDayId);
            builder.ToTable("DietPlanDays");
            builder.HasOne(x => x.DietPlan)
                .WithMany(x => x.DietPlanDays).HasForeignKey(x => x.DietPlanId).OnDelete(DeleteBehavior.Cascade);
        }

    }
}
