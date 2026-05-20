using System.Globalization;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

var builder = WebApplication.CreateBuilder(args);

// Force en-US so currency renders as "$" regardless of the host OS locale.
var enUs = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = enUs;
CultureInfo.DefaultThreadCurrentUICulture = enUs;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcMovieContext")
        ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));

var app = builder.Build();

// Apply any pending migrations and seed the database on startup.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<MvcMovieContext>();
    context.Database.Migrate();
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
