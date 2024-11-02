using Bogus;
using EquipEventTrack.Domain.Handlers.Users;
using EquipEventTrack.Domain.Handlers.Users.Update;

namespace EquipEventTrack.Test.FakerData;

public static class FakeUserCommands
{
    public static CreateCommand CreateCommand()
    {
        return new Faker<CreateCommand>()
            .RuleFor(p => p.UserName, f => f.Person.FullName)
            .RuleFor(p => p.Password, f => f.Random.Hash())
            .RuleFor(p => p.Email, f => f.Person.Email);
    }

    public static UpdateCommand UpdateCommand()
    {
        return new Faker<UpdateCommand>()
            .RuleFor(p => p.Id, f=> f.Random.Int(1, 10))
            .RuleFor(p => p.UserName, f => f.Person.FullName)
            .RuleFor(p => p.Password, f => f.Random.Hash())
            .RuleFor(p => p.Email, f => f.Person.Email);
    }
}