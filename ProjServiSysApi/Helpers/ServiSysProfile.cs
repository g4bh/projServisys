using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjServiSys.Domain;
using ProjServiSys.Application.Dto;
using ProjServiSys.Domain.Identity;

namespace ProjServiSys.Application.Helpers
{
    public class ServiSysProfile : Profile
    {
        public ServiSysProfile() 
        {
            CreateMap<OrdemServico, OrdemServicoDto>().ReverseMap();
            CreateMap<OrdemEquipamento, OrdemEquipamentoDto>().ReverseMap();
            CreateMap<Lancamento, LancamentoDto>().ReverseMap();
            CreateMap<Equipamento, EquipamentoDto>().ReverseMap();
            CreateMap<Ambiente, AmbienteDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}