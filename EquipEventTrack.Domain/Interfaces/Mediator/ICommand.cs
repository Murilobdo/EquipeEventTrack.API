using EquipEventTrack.Domain.Handlers;
using MediatR;

namespace EquipEventTrack.Domain.Interfaces.Mediator;

public interface ICommand : IRequest<Response>
{
    bool IsValid();
    List<string> GetErrors();
}