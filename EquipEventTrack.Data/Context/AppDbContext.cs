using EquipEventTrack.Data.Mapping;
using EquipEventTrack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace EquipEventTrack.Data.Context;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<UserEntity>(options)
{
    public DbSet<CategoryEntity> Categorys { get; set; }
    public DbSet<EquipmentEntity> Equipments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CategoryMap());
        builder.ApplyConfiguration(new EquipmentMap());

        base.OnModelCreating(builder);
    }
}