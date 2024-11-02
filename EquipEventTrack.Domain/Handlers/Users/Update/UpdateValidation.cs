using FluentValidation;

namespace EquipEventTrack.Domain.Handlers.Users.Update;

public class UpdateValidation : AbstractValidator<UpdateCommand>
{
    public UpdateValidation()
    {
        RuleFor(p => p.Id)
            .GreaterThan(0)
            .WithMessage("Não foi possivel finalizar a ação");
        
        RuleFor(p => p.UserName)
            .NotEmpty()
            .WithMessage("O nome e obrigatório");
        
        RuleFor(p => p.Email)
            .NotEmpty()
            .WithMessage("O e-mail e obrigatório");
            
        RuleFor(p => p.Email)
            .EmailAddress()
            .WithMessage("Insira um e-mail valido");
    }
}