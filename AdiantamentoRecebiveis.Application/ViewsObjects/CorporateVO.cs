using AdiantamentoRecebiveis.Domain.Enum;
using System;

namespace AdiantamentoRecebiveis.Application.ViewsObjects;

public class CorporateVO
{
    public string? Nome { get; set; }
    public string? Cnpj { get; set; }
    public TipoRamo TipoRamo { get; set; }
    public decimal FaturamentoMensal { get; set; }
}
