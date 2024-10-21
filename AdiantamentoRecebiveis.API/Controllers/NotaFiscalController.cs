using AdiantamentoRecebiveis.API.Middlewares;
using AdiantamentoRecebiveis.Application.ViewsObjects;
using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AdiantamentoRecebiveis.API.Controllers;

/// <summary>
/// Controller for handling notafiscais registrations.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class NotaFiscalController(INotaFiscalService _service, IMapper _mapper) : BaseController
{
    /// <summary>
    /// Cria notas ficais
    /// </summary>
    /// <param name="createDTO"></param>
    /// <returns></returns>
    [HttpPost("create")]
    public async Task<ActionResult> Create([FromBody] NotasFicaisVO createDTO)
    {
        try
        {
            if (createDTO is null)
                return BuildResponse(success: false, message: "Invalid Request", statusCode: HttpStatusCode.BadRequest);

            return BuildResponse(await _service.CreateAsync(_mapper.Map<NotasFiscais>(createDTO)), message: "NotaFiscal cadastrada com sucesso!");
        }
        catch (DefaultException ex)
        {
            return BuildResponse(success: false, message: ex.Message, statusCode: ex._statusCode!.Value);
        }
    }
}
