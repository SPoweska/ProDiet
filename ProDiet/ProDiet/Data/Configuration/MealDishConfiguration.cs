//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using ProDiet.Models.DietPlan;

//namespace ProDiet.Data.Configuration
//{

//    public class MealDishConfiguration : IEntityTypeConfiguration<MealDish>
//    {
//        public void Configure(EntityTypeBuilder<MealDish> builder)
//        {

//            builder.HasKey(x => x.MealDishId);
//            builder.ToTable("MealDishes");
//            builder.HasOne(x => x.DayMeal).WithOne(x => x.MealDish).HasForeignKey<DayMeal>(x=>x.MealDishId)
//                .OnDelete(DeleteBehavior.Cascade);

//        }



//    }

//}



