
using AdiantamentoRecebiveis.Domain.Entities;

namespace AdiantamentoRecebiveis.Domain.Repositories;

public interface INotaFiscalRepository
{
    Task<NotasFiscais> CreateAsync(NotasFiscais createDTO);
    Task<NotasFiscais> GetAsync(int id);
}
