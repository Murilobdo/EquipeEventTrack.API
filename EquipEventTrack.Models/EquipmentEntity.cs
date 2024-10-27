namespace EquipEventTrack.Models;

public record EquipmentEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CodeNumber { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; }
}