

using AdiantamentoRecebiveis.Domain.Entities;

namespace AdiantamentoRecebiveis.Domain.Services;

public interface ICartNfService
{
    Task<CartNf> CreateAsync(CartNf createDTO);
}
