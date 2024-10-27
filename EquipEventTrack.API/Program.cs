using EquipEventTrack.Data.Context;
using EquipEventTrack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=127.0.0.1;Database=EquipEventTrack;Encrypt=true;TrustServerCertificate=true; User Id=sa; Password=Local@db123");
});

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services
    .AddIdentityApiEndpoints<UserEntity>()
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");

app.MapPost("/logout", 
    async (SignInManager<UserEntity> signInManager, [FromBody] object emplty) =>
    {
        await signInManager.SignOutAsync();
        return Results.Ok();
    }
);

app.MapIdentityApi<UserEntity>();

app.UseHttpsRedirection();

app.Run();

