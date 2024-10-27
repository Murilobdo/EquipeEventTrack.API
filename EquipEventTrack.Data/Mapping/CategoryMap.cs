using EquipEventTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EquipEventTrack.Data.Mapping;

public class CategoryMap : IEntityTypeConfiguration<CategoryEntity>
{
    public void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {
        builder.ToTable("Categorys");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name)
            .HasMaxLength(20);
    }
}