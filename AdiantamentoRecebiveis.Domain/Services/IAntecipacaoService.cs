

using AdiantamentoRecebiveis.Application.Dto;

namespace AdiantamentoRecebiveis.Domain.Services;

public interface IAntecipacaoService
{
    Task<AntecipacaoDto> CalculaAntecipado(int empresaId, List<int> notaFiscalIds);
}
