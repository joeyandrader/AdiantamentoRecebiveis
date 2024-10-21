using System;

namespace AdiantamentoRecebiveis.Application.ViewsObjects;

public class NotasFicaisVO
{
    public int? Numero { get; set; }
    public decimal? ValorBruto { get; set; }
    public DateTime? DataVencimento { get; set; }
    public int? EmpresaId { get; set; }
}
