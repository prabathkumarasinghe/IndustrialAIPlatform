using IndustrialAI.Application.Commands.Machine.RegisterMachine;
using IndustrialAI.Application.Interfaces;
using IndustrialAI.Domain.Entities;
using MediatR;

namespace IndustrialAI.Application.Handlers.Machine;

public class RegisterMachineHandler
    : IRequestHandler<RegisterMachineCommand, Guid>
{
    private readonly IMachineRepository _repository;

    //public RegisterMachineHandler(IMachineRepository repository)
    //{
    //    _repository = repository;
    //}

    public async Task<Guid> Handle(
        RegisterMachineCommand request,
        CancellationToken cancellationToken)
    {
        var machine = new Domain.Entities.Machine(
            request.Name,
            request.SerialNumber);

        //await _repository.AddAsync(machine);

        return machine.Id;
    }
}