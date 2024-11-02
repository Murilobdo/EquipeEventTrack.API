namespace EquipEventTrack.Models;

public record EquipmentEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CodeNumber { get; set; } = string.Empty;
    public CategoryEntity Category { get; set; }
    public int CategoryId { get; set; }
}
