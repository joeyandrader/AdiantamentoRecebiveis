

using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Repositories;
using MediatR;

namespace AdiantamentoRecebiveis.Application.Queries.NotaFiscal.ObterListaNotaFiscal;

public class ObterListaNotaFiscalQueryHandler(INotaFiscalRepository _repository) : IRequestHandler<ObterListaNotaFiscalQuery, IEnumerable<Domain.Entities.NotasFiscais>>
{
    public async Task<IEnumerable<NotasFiscais>> Handle(ObterListaNotaFiscalQuery request, CancellationToken cancellationToken)
    {
        return await _repository.List();
    }
}
