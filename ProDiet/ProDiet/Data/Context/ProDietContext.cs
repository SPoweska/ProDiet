﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProDiet.Data.Configuration;
using ProDiet.Data.Models;
using ProDiet.Models;
using ProDiet.Models.DietPlan;

namespace ProDiet.Data;

public class ProDietContext : IdentityDbContext<IdentityUser>
{
    public ProDietContext(DbContextOptions<ProDietContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Alergene> Alergenes { get; set; }
    public DbSet<HomeMeasurement> HomeMeasurements { get; set; }
    public DbSet<Nutrient> Nutrients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Intolerance> Intolerances { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<UsedProduct> UsedProducts { get; set; }
    public DbSet<BodyMeasurement> BodyMeasurements { get; set; }
    public DbSet<DietPlan> DietPlans { get; set; }
    public DbSet<DietPlanDay> DietPlanDays { get; set; }
    public DbSet<DayMeal> DayMeals { get; set; }
    public DbSet<DietPlanDayDish> DietPlanDayDishes { get; set; }
    public DbSet<DietPlanShoppingList> DietPlanShoppingLists { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(PatientConfiguration).Assembly);
        base.OnModelCreating(builder);

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
