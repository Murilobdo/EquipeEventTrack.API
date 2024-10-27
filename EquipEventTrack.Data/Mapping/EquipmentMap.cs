using EquipEventTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EquipEventTrack.Data.Mapping;

public class EquipmentMap : IEntityTypeConfiguration<EquipmentEntity>
{
    public void Configure(EntityTypeBuilder<EquipmentEntity> builder)
    {
        builder.ToTable("Equipments");
        builder.HasKey(p => p.Id);
        builder.HasOne(p => p.Category)
            .WithOne();

        builder.HasOne(p => p.Category)
            .WithMany(p => p.Equipments)
            .HasForeignKey(p => p.Id);
    }
}