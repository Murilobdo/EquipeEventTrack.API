using EquipEventTrack.Models;
using FluentValidation;

namespace EquipEventTrack.Domain.Handlers.Users;

public class CreateValidation : AbstractValidator<CreateCommand>
{
    public CreateValidation()
    {
        RuleFor(p => p.UserName)
            .NotEmpty()
            .WithMessage("O nome e obrigatório");
        
        RuleFor(p => p.Email)
            .NotEmpty()
            .WithMessage("O e-mail e obrigatório");
            
        RuleFor(p => p.Email)
            .EmailAddress()
            .WithMessage("Insira um e-mail valido");

        RuleFor(p => p.Password)
            .NotEmpty()
            .WithMessage("A senha e obrigatória");
    }
}