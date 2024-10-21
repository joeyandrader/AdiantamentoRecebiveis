
using AdiantamentoRecebiveis.Application.Dto;
using AdiantamentoRecebiveis.Domain.Dto;
using AdiantamentoRecebiveis.Domain.Entities;

namespace AdiantamentoRecebiveis.Domain.Services;
public interface ICartService
{
    Task<AntecipacaoDto> CreateAsync(int empresaId, List<int> NfsId);

    Task<AntecipacaoDto> GetAsync(int empresaId, int cartId);
}
