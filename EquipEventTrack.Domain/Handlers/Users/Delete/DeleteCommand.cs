using EquipEventTrack.Domain.Interfaces.Mediator;
using EquipEventTrack.Models;

namespace EquipEventTrack.Domain.Handlers.Users.Delete;

public class DeleteCommand : UserEntity, ICommand
{

    public DeleteCommand(int id)
    {
        Id = id;
    }
    
    public bool IsValid()
    {
        return Id > 0;
    }

    public List<string> GetErrors()
    {
        if (Id <= 0)
            return new List<string>() { "Não foi possivel finalizar a ação" };

        return new List<string>();
    }
}