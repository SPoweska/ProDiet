using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProDiet.Models.DietPlan;

namespace ProDiet.Data.Configuration
{

    public class MealDishConfiguration : IEntityTypeConfiguration<DayMeal>
    {
        public void Configure(EntityTypeBuilder<DayMeal> builder)
        {
            builder.HasOne(x => x.MealDish).WithOne(x => x.DayMeal).HasForeignKey<MealDish>(x => x.MealId);

        }



    }

}



