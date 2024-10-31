
using MediatR;

namespace AdiantamentoRecebiveis.Application.Queries.NotaFiscal.ObterListaNotaFiscal;

public class ObterListaNotaFiscalQuery : IRequest<IEnumerable<Domain.Entities.NotasFiscais>> { }
