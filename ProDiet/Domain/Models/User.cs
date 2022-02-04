using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        [Required]
        public string FristName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string Description { get; set; }
        public Role Role { get; set; }
    }
}
