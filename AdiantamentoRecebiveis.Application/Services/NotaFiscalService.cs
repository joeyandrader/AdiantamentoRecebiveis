
using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Repositories;
using AdiantamentoRecebiveis.Domain.Services;

namespace AdiantamentoRecebiveis.Application.Services;

public class NotaFiscalService(INotaFiscalRepository _repository) : INotaFiscalService
{
    public async Task<NotasFiscais> CreateAsync(NotasFiscais createDTO)
    {

        createDTO.Taxa = 4.65m;
        //var taxaPercentCalc = 1 + (createDTO.Taxa / 100);
        //createDTO.Prazo = (createDTO.DataVencimento - DateTime.Now).Days;
        //createDTO.Desagio = createDTO.ValorBruto - (createDTO.ValorBruto / Math.Round((decimal)Math.Pow(Convert.ToDouble(taxaPercentCalc), (createDTO.Prazo.Value / 30.0)), 2));
        //createDTO.ValorLiquido = createDTO.ValorBruto - createDTO.Desagio.Value;

        return await _repository.CreateAsync(createDTO);
    }

    public async Task<NotasFiscais> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }
}
