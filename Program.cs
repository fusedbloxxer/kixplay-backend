using KixPlay_Backend.Data;
using KixPlay_Backend.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure the connection to the database by specifying the connection string
builder.Services.AddDbContext<DataContext>(contextOptions =>
{
    contextOptions.UseSqlServer(
        builder.Configuration.GetConnectionString("KixPlayDatabaseConnection")
    );
});

// Add Authentication & Authorization
builder.Services.AddAuthServices(builder.Configuration);

// Add automapping in this assembly to convert between models and dtos
builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Build the application using the configured services
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
