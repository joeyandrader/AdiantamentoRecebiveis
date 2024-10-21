

using AdiantamentoRecebiveis.Domain.Entities;

namespace AdiantamentoRecebiveis.Domain.Services;

public interface INotaFiscalService
{
    Task<NotasFiscais> CreateAsync(NotasFiscais createDTO);
    Task<NotasFiscais> GetAsync(int id);
}
