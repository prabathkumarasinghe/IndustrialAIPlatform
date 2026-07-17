using MediatR;

namespace IndustrialAI.Application.Commands.Machine.RegisterMachine;

public record RegisterMachineCommand(
    string Name,
    string SerialNumber) : IRequest<Guid>;