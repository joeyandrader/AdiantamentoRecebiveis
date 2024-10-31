using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Repositories;
using MediatR;

namespace AdiantamentoRecebiveis.Application.Queries.Empresa.ObterListaEmpresa;

public class ObterListaEmpresaQueryHandler(ICorporateRepository _repository) : IRequestHandler<ObterListaEmpresaQuery, IEnumerable<Domain.Entities.Corporate>>
{
    public async Task<IEnumerable<Corporate>> Handle(ObterListaEmpresaQuery request, CancellationToken cancellationToken)
    {
        return await _repository.List();
    }
}
