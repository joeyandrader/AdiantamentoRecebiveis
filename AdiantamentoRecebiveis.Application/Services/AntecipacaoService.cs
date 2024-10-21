

using AdiantamentoRecebiveis.Application.Dto;
using AdiantamentoRecebiveis.Domain.Services;

namespace AdiantamentoRecebiveis.Application.Services;

public class AntecipacaoService : IAntecipacaoService
{
    public Task<AntecipacaoDto> CalculaAntecipado(int empresaId, List<int> notaFiscalIds)
    {
        throw new NotImplementedException();
    }
}
