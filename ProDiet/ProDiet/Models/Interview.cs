

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProDiet.Data.Models;

namespace ProDiet.Models
{
    public class Interview:AuditableEntity
    {
        [Key]
        public int InterviewId { get; set; }
        public Patient Patient { get; set; }
        [Required]
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        
        public string? VisitReason { get; set; }
        public string? Goals { get; set; }
        public string? PhysicalActivity { get; set; }
        public string? VisitGoal { get; set; }
        public string? Diseases { get; set; }
        public string? Suplementation { get; set; }
        public string? PALActivity { get; set; }
        public string? FamilyDiseases { get; set; }
        public string? DigestiveDiseases { get; set; }
        public string? HealthProblems { get; set; }
        public string? DietHistory { get; set; }
        public string? Profession { get; set; }
        public bool? FoodHeatingAbility { get; set; }
        public string? TypicalEatingShedules { get; set; }
        public string? LastMealTime { get; set; }
        public string? DailySnacksAmount { get; set; }
        public string? PreferedSnacks { get; set; }
        public string? TimeWhenEatsMost { get; set; }
        public string? UnlikedFoods { get; set; }
        public string? PreferedFats { get; set; }
        public string? PreferedBreads { get; set; }
        public string? WeeklyBread { get; set; }
        public string? PreferedCarbProducts { get; set; }
        public string? WeeklyDairy { get; set; }
        public string? PreferedDairy { get; set; }
        public string? WeeklyVegetables { get; set; }
        public string? WeeklyFlourProducts { get; set; }
        public string? WeeklyMeat { get; set; }
        public string? PreferedMeat { get; set; }
        public string? WeeklyFish { get; set; }
        public string? PreferedFish { get; set; }
        public string? PreferedDrinks { get; set; }
        public string? PreferedSweeteners { get; set; }
        public string? WeeklyCandies { get; set; }
        public string? WeeklyFastFoods { get; set; }
        public string? WeeklyAlkohol { get; set; }



    }
}
