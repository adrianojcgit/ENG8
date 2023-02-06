using AutoMapper;
using ENG8.Application.DTOs;
using ENG8.Application.ModelView;
using ENG8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8.Application.Mappings
{
	public class DomaintToDTOMappingProfile : Profile
	{
		public DomaintToDTOMappingProfile()
		{
			CreateMap<Cliente, ClienteDTO>().ReverseMap();
			CreateMap<Endereco, EnderecoDTO>().ReverseMap();
			CreateMap<Cliente, ClienteView>().ReverseMap();
		}
	}
}
