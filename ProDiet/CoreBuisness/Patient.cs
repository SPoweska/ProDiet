using System.ComponentModel.DataAnnotations;
using ProDiet.Models;

namespace CoreBuisness
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public DateTime Birth_Date { get; set; }

        public Interview Interview { get; set; }

        public int Height { get; set; }
        public int Weight { get; set; }

        [Required]
        public string Phone_Number { get; set; }

        [Required]
        public string Email { get; set; }

        public float BMI { get; set; }
        public float BMR { get; set; }
        public float PAL { get; set; }
        public float PPM { get; set; }
        public float CPM { get; set; }


        //public List<DietPlan> DietPlans { get; set; }
        //[Required]
        //public ApplicationUser UserDietetician { get; set; }
        //public ApplicationUser UserPatient { get; set; }

    }
}
