using AdiantamentoRecebiveis.API.Extensions;
using AdiantamentoRecebiveis.API.Responses;
using AdiantamentoRecebiveis.Application.Commands.Carrinho.Cadastro;
using AdiantamentoRecebiveis.Application.Commands.Corporate.Cadastro;
using AdiantamentoRecebiveis.Application.Queries.Empresa.ObterEmpresa;
using AdiantamentoRecebiveis.Application.Queries.Empresa.ObterListaEmpresa;
using AdiantamentoRecebiveis.Domain.Entities;
using MediatR;

namespace AdiantamentoRecebiveis.API.Controllers;

public static class CorporateController
{
    private const string Grupo = "Empresa";
    public static void RegistrarEmpresaController(this WebApplication app)
    {
        var corporateGrupo = app
          .CriaGrupo(Grupo)
          .WithTags(Grupo);


        corporateGrupo.MapPost("/",
            async (CorporateCadastroCommand request, IMediator mediator) =>
            GlobalResponse.Create201Response(await mediator.Send(request)))
            .Produces(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status500InternalServerError)
            .Accepts<CarrinhoCadastroCommand>("application/json");

        corporateGrupo.MapGet("/{id}",
           async ([AsParameters] ObterEmpresaQuery request, IMediator mediator) =>
           {
              return GlobalResponse.Create201Response(await mediator.Send(request));
           })
           .Produces(StatusCodes.Status201Created, typeof(Corporate))
           .Produces(StatusCodes.Status400BadRequest)
           .Produces(StatusCodes.Status500InternalServerError);

        corporateGrupo.MapGet("/list",
           async ([AsParameters] ObterListaEmpresaQuery request, IMediator mediator) =>
           {
              return GlobalResponse.Create201Response(await mediator.Send(request));
           })
           .Produces(StatusCodes.Status201Created)
           .Produces(StatusCodes.Status400BadRequest)
           .Produces(StatusCodes.Status500InternalServerError);
    }

}
