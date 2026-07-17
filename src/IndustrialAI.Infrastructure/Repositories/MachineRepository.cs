using IndustrialAI.Application.Interfaces;
using IndustrialAI.Domain.Entities;
using IndustrialAI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndustrialAI.Infrastructure.Repositories;

public class MachineRepository : IMachineRepository
{
    private readonly IndustrialDbContext _context;

    public MachineRepository(IndustrialDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Machine machine)
    {
        _context.Machines.Add(machine);
        await _context.SaveChangesAsync();
    }

    public async Task<Machine?> GetByIdAsync(Guid id)
    {
        return await _context.Machines.FindAsync(id);
    }

    public async Task<List<Machine>> GetAllAsync()
    {
        return await _context.Machines.ToListAsync();
    }

    public async Task UpdateAsync(Machine machine)
    {
        _context.Update(machine);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var machine = await _context.Machines.FindAsync(id);

        if (machine != null)
        {
            _context.Remove(machine);
            await _context.SaveChangesAsync();
        }
    }
}