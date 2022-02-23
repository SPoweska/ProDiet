using Microsoft.AspNetCore.Identity;

namespace ProDiet.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
