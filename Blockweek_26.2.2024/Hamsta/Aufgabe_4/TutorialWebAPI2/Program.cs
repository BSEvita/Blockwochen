using BookStore.Data.Database;
using BookStore.Data.Interface;
using BookStore.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BookContext>(options =>
{
    options.UseInMemoryDatabase("BooksDatabase");
});

builder.Services.AddScoped<DatabaseInitializerService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("https://localhost:7105")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

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
