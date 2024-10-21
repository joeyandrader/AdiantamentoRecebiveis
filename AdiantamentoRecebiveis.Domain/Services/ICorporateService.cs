using AdiantamentoRecebiveis.Domain.Entities;

namespace AdiantamentoRecebiveis.Domain.Services;

public interface ICorporateService
{
    public Task<Corporate> GetAsync(int id);
    public Task<Corporate> Create(Corporate corporate);
}
