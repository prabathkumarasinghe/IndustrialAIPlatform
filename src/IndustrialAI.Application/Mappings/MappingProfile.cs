using AutoMapper;
using IndustrialAI.Application.DTOs;
using IndustrialAI.Domain.Entities;

namespace IndustrialAI.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Machine, MachineDto>();

        CreateMap<Sensor, SensorDto>();

        CreateMap<Prediction, PredictionDto>();
    }
}