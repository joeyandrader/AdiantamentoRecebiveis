
using MediatR;

namespace AdiantamentoRecebiveis.Application.Queries.Empresa.ObterListaEmpresa;

public class ObterListaEmpresaQuery : IRequest<IEnumerable<Domain.Entities.Corporate>> { }
