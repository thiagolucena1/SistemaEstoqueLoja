using AutoMapper;
using EstoqueLojaV._0._2.Models.ClientesEntites;
using EstoqueLojaV._0._2.Models.DTO;

namespace EstoqueLojaV._0._2.Data.Mapping
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteEditarDTO, Cliente>()
                .ForMember(dest => dest.CpfCnpj, opt => opt.MapFrom(src => src.CpfOuCnpj))
                .ReverseMap();
        }
    }
}
