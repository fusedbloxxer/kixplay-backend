using KixPlay_Backend.Authorization.Handlers;
using KixPlay_Backend.Authorization.Requirements;
using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Extensions;
using KixPlay_Backend.Services.Repositories.Implementations;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
        .AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add automapping in this assembly to convert between models and dtos
builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Configure the connection to the database by specifying the connection string
builder.Services.AddDbContext<DataContext>(contextOptions =>
{
    contextOptions.UseSqlServer(
        builder.Configuration.GetConnectionString("KixPlayDatabaseConnection")
    );
});

// Add Authentication & Authorization
builder.Services.AddAuthServices(builder.Configuration);

// Create Custom Authorization Policies
builder.Services.AddAuthorizationCore(options =>
{
    options.AddPolicy("IsSameUser", policy =>
    {
        policy.Requirements.Add(new IsSameUserRequirement());
    });
});

// Add logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add authorization handlers
builder.Services.AddSingleton<IAuthorizationHandler, IsSameUserHandler>();
builder.Services.AddSingleton<IAuthorizationHandler, AdminHandler>();

// Add services
builder.Services.AddScoped<IUserRoleRepository, UserRoleRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
