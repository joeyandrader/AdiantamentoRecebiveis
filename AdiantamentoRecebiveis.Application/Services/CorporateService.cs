using System;
using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Repositories;
using AdiantamentoRecebiveis.Domain.Services;

namespace AdiantamentoRecebiveis.Application.Services;

public class CorporateService(ICorporateRepository _repository) : ICorporateService
{
    public async Task<Corporate> Create(Corporate corporate)
    {
        corporate.Limite = corporate.CalcularLimite();

        return await _repository.Create(corporate);
    }

    public async Task<Corporate> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }
}
