using AdiantamentoRecebiveis.API.Middlewares;
using AdiantamentoRecebiveis.Application.ViewsObjects;
using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdiantamentoRecebiveis.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CartController(ICartService _service, IMapper _mapper) : BaseController
{
    [HttpPost]
    public async Task<ActionResult> Create([FromBody] CartVO createDTO)
    {
        try
        {
            return BuildResponse(await _service.CreateAsync(createDTO.EmpresaId, createDTO.NfsId), message: "Carrinho criado com sucesso!");
        }
        catch (DefaultException ex)
        {
            return BuildResponse(success: false, message: ex.Message, statusCode: ex._statusCode!.Value);
        }
    }

    [HttpGet]
    public async Task<ActionResult> GetCart([FromQuery] int empresaId, int cartId)
    {
        try
        {
            return BuildResponse(await _service.GetAsync(empresaId, cartId), message: "Carrinho carregado com sucesso!");
        }
        catch (DefaultException ex)
        {
            return BuildResponse(success: false, message: ex.Message, statusCode: ex._statusCode!.Value);
        }
    }
}
