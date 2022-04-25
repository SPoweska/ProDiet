using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models.DietPlan
{
    public class DietPlanShoppingList : AuditableEntity
    {
        [Key] public int ShoppingListId { get; set; }
        public DietPlan DietPlan { get; set; }
        [Required]
        [ForeignKey("DietPlanId")]
        public int DietPlanId { get; set; }
        public List<UsedProduct> UsedProducts { get; set; }
    }
}
