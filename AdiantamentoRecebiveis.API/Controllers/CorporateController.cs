using System.Net;
using AdiantamentoRecebiveis.API.Middlewares;
using AdiantamentoRecebiveis.Application.ViewsObjects;
using AdiantamentoRecebiveis.Domain.Entities;
using AdiantamentoRecebiveis.Domain.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdiantamentoRecebiveis.API.Controllers;

/// <summary>
/// Controller for handling corporate registrations.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class CorporateController(ICorporateService _service, IMapper _mapper) : BaseController
{
    /// <summary>
    /// Registers a new corporate entity.
    /// </summary>
    /// <param name="createDTO">The corporate data transfer object (DTO) for creation.</param>
    /// <returns>An <see cref="ActionResult"/> containing the created corporate entity.</returns>
    [HttpPost("create")]
    public async Task<ActionResult> Create([FromBody] CorporateVO createDTO)
    {
        try
        {
            if (createDTO is null)
                return BuildResponse(success: false, message: "Invalid Request", statusCode: HttpStatusCode.BadRequest);

            return BuildResponse(await _service.Create(_mapper.Map<Corporate>(createDTO)), message: "Empresa cadastrada com sucesso!");
        }
        catch (DefaultException ex)
        {
            return BuildResponse(success: false, message: ex.Message, statusCode: ex._statusCode!.Value);
        }
    }
}
