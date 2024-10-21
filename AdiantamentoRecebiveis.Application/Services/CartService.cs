using AdiantamentoRecebiveis.Application.Dto;
using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Repositories;
using AdiantamentoRecebiveis.Domain.Services;

namespace AdiantamentoRecebiveis.Application.Services;
public class CartService(
    ICartRepository _repository,
    ICartNfRepository _cartNfRepository,
    INotaFiscalRepository _notaFiscalRepository,
    IAntecipacaoRepository _antecipacaoRepository
    ) : ICartService
{
    public async Task<AntecipacaoDto> CreateAsync(int empresaId, List<int> NfsId)
    {
        Cart cart = new Cart();
        cart.CorporateId = empresaId;

        var createCart = await _repository.CreateAsync(cart);
        if (createCart != null)
        {
            foreach (var id in NfsId)
            {
                //buscar as nfs
                var getNf = await _notaFiscalRepository.GetAsync(id);
                if (getNf != null)
                {
                    await _cartNfRepository.CreateAsync(new CartNf
                    {
                        CartId = createCart.Id!.Value,
                        NotasFiscaisId = getNf.Id!.Value,
                    });
                }
                else
                    continue;
            }
        }
        else
            throw new Exception("Houve um problema ao criar o carrinho!");

        return await _antecipacaoRepository.CalculaAntecipado(empresaId, createCart.Id!.Value);
    }

    public async Task<AntecipacaoDto> GetAsync(int empresaId, int cartId)
    {
        return await _antecipacaoRepository.CalculaAntecipado(empresaId, cartId);
    }
}
