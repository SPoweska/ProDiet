using System.ComponentModel.DataAnnotations;

namespace CoreBuisness
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
    }
}
