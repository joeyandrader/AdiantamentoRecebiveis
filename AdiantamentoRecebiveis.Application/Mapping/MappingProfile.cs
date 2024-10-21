using System;
using AdiantamentoRecebiveis.Application.ViewsObjects;
using AdiantamentoRecebiveis.Domain.Entities;
using AutoMapper;

namespace AdiantamentoRecebiveis.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        #region Empresa
        CreateMap<CorporateVO, Corporate>()
        .ForMember(x => x.Nome, b => b.MapFrom(x => x.Nome))
        .ForMember(x => x.Cnpj, b => b.MapFrom(x => x.Cnpj))
        .ForMember(x => x.TipoRamo, b => b.MapFrom(x => x.TipoRamo))
        .ForMember(x => x.FaturamentoMensal, b => b.MapFrom(x => x.FaturamentoMensal))
        .ReverseMap();
        #endregion

        #region NotaFiscal
        CreateMap<NotasFicaisVO, NotasFiscais>()
            .ForMember(x => x.Numero, b => b.MapFrom(x => x.Numero))
            .ForMember(x => x.DataVencimento, b => b.MapFrom(x => x.DataVencimento))
            .ForMember(x => x.ValorBruto, b => b.MapFrom(x => x.ValorBruto))
            .ForMember(x => x.CorporateId, b => b.MapFrom(x => x.EmpresaId))
            .ReverseMap();
        #endregion
    }

}
