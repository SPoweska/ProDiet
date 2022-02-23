using System.ComponentModel.DataAnnotations;

namespace ProDiet.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
    }
}
