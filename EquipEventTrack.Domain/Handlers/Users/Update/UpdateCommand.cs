using EquipEventTrack.Domain.Interfaces.Mediator;
using EquipEventTrack.Models;

namespace EquipEventTrack.Domain.Handlers.Users.Update;

public class UpdateCommand : UserEntity, ICommand
{
    public string Password { get; set; }
    public bool IsValid()
    {
        var validation = new UpdateValidation()
            .Validate(this);

        return validation.IsValid;
    }

    public List<string> GetErrors()
    {
        return new UpdateValidation()
            .Validate(this)
            .Errors
            .Select(p => p.ErrorMessage)
            .ToList();
    }
}