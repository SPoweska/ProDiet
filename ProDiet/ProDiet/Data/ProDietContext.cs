using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProDiet.Models;

namespace ProDiet.Data;

public class ProDietContext : IdentityDbContext<IdentityUser>
{
    public ProDietContext(DbContextOptions<ProDietContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    //public DbSet<AuditableEntity> AuditableEntities { get; set; }

    public DbSet<Gender> Genders { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Patient> Patients { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
