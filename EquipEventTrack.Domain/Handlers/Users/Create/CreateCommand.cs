using EquipEventTrack.Domain.Interfaces.Mediator;
using EquipEventTrack.Models;
using MediatR;

namespace EquipEventTrack.Domain.Handlers.Users;

public class CreateCommand : UserEntity, ICommand
{
    public string Password { get; set; }

    public CreateCommand(string userName, string email, string password)
    {
        
    }

    public CreateCommand()
    {
        
    }
    public bool IsValid()
    {
        var validation = new CreateValidation()
            .Validate(this);

        return validation.IsValid;
    }

    public List<string> GetErrors()
    {
        return new CreateValidation()
            .Validate(this)
            .Errors
            .Select(p => p.ErrorMessage)
            .ToList();
    }
}