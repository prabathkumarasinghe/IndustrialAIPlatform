using IndustrialAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndustrialAI.Infrastructure.Persistence.Configurations;

public class MachineConfiguration : IEntityTypeConfiguration<Machine>
{
    public void Configure(EntityTypeBuilder<Machine> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
               .HasMaxLength(100)
               .IsRequired();

        builder.Property(x => x.SerialNumber)
               .HasMaxLength(100)
               .IsRequired();
    }
}