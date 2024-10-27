namespace EquipEventTrack.Models;

public record CategoryEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<EquipmentEntity> Equipments { get; set; }
}