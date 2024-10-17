using GestionPersonas.Models;
using GestionPersonas.Repositories;
using GestionPersonas.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PersonasDBContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("cnPersonasDB")));

builder.Services.AddScoped<IPersonaService, PersonaService>();
builder.Services.AddScoped<IPersonaRepository, PersonaRepository>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Personas}/{action=Index}/{id?}");

app.Run();
