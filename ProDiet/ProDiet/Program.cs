using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ProDiet.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProDiet.Areas.Identity;
using ProDiet.Models;
using ProDiet.Services;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");builder.Services.AddDbContext<ProDietContext>(options =>
    options.UseSqlServer(connectionString),ServiceLifetime.Transient);builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ProDietContext>();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IPatientStoresService,PatientStoresService>();
builder.Services.AddScoped<IDishStoresService, DishStoresService>();
builder.Services.AddScoped<IProductStoresService, ProductStoresService>();
//builder.Services.AddScoped<IUsedProductStoresService, UsedProductStoresService>();
builder.Services.AddScoped<IAlergeneStoresService, AlergeneStoresService>();
builder.Services.AddScoped<TokenProvider>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<UserManager<IdentityUser>>();
builder.Services.AddMudServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapBlazorHub();
app.MapRazorPages();
app.MapFallbackToPage("/_Host");

app.Run();
