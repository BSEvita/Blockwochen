using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Models.SeedData;

// Create a new instance of WebApplicationFactory builder
var builder = WebApplication.CreateBuilder(args);

// Add an instance of MvcMovieContext to the dependency injection container
builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));
  
// Add MvcMovieControllers to the dependency injection container
builder.Services.AddControllersWithViews();

// Build the WebApplication object
var app = builder.Build();

// Create a scope to execute the SeedData.Initialize method
using (var scope = app.Services.CreateScope())
{
    // Get the ServiceProvider from the scope
    var services = scope.ServiceProvider;
  
    // Initialize the SeedData
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    // Use the ExceptionHandler middleware to handle errors
    app.UseExceptionHandler("/Home/Error");
  
    // Enable HTTP Strict Transport Security (HSTS) to force secure connections
    // The default value is 30 days. You may want to change this for production scenarios
    app.UseHsts();
}

// Configure HTTPS redirection
app.UseHttpsRedirection();

// Configure static file serving
app.UseStaticFiles();

// Configure routing
app.UseRouting();

// Configure authorization
app.UseAuthorization();

// Map the default controller route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Run the application
app.Run();