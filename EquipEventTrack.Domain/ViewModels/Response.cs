namespace EquipEventTrack.Domain.Handlers;

public record Response
{
    public object Data { get; set; }
    public bool IsValid { get; set; }
    public string Message { get; set; }
}