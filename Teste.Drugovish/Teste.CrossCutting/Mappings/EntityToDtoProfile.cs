using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Dtos.Cliente;
using Teste.Domain.Dtos.Gerente;
using Teste.Domain.Dtos.Grupo;
using Teste.Domain.Entities;

namespace Teste.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ClienteDto, Cliente>()
                .ReverseMap();
            CreateMap<GerenteDto, Gerente>()
                .ReverseMap();
            CreateMap<GrupoDto, Grupo>()
                .ReverseMap();
        }
    }
}
