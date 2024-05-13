using Aufgabe_2.Data.Database;
using Aufgabe_2.Data.Interface;
using Aufgabe_2.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BookContext>(options =>
{
    options.UseSqlServer("Server=localhost;Database=master;User Id=sa;Password=admin1234!;Trusted_Connection=False;Encrypt=False;", b => b.MigrationsAssembly("Aufgabe_2"));
});

builder.Services.AddDbContext<UserContext>(options =>
{
    options.UseSqlServer("Server=localhost;Database=master;User Id=sa;Password=admin1234!;Trusted_Connection=False;Encrypt=False;", b => b.MigrationsAssembly("Aufgabe_2"));
});

builder.Services.AddScoped<DatabaseInitializerService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("*")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbInitializer = services.GetRequiredService<DatabaseInitializerService>();
    dbInitializer.Initialize();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowSpecificOrigin");

app.MapControllers();

app.Run();