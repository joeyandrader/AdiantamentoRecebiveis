

using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Repositories;
using AdiantamentoRecebiveis.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AdiantamentoRecebiveis.Infrastructure.Repositories;
public class NotaFiscalRepository(DataContext _context) : INotaFiscalRepository
{
    public async Task<NotasFiscais> CreateAsync(NotasFiscais createDTO)
    {
        _context.Add(createDTO);
        await _context.SaveChangesAsync();
        return createDTO;
    }

    public async Task<NotasFiscais> GetAsync(int id)
    {
        var result = await _context.notasFiscais.FirstOrDefaultAsync(x => x.Id.Equals(id));
        if (result == null)
            throw new Exception("Nota fiscal não encontrada!");
        return result;
    }
}
