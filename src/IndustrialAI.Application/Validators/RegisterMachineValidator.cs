using FluentValidation;
using IndustrialAI.Application.Commands.Machine.RegisterMachine;

namespace IndustrialAI.Application.Validators;

public class RegisterMachineValidator
    : AbstractValidator<RegisterMachineCommand>
{
    public RegisterMachineValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.SerialNumber)
            .NotEmpty();
    }
}