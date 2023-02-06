using ENG8.Application.DTOs;
using ENG8.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8.Application.Services
{
	public class EnderecoService : IEnderecoService
	{
		private readonly IEnderecoService _servive;

		public EnderecoService(IEnderecoService servive)
		{
			_servive = servive;
		}

		public Task<EnderecoDTO> Create(EnderecoDTO endereco)
		{
			throw new NotImplementedException();
		}

		public Task<EnderecoDTO> GetById(int? id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<EnderecoDTO>> GetEnderecos()
		{
			throw new NotImplementedException();
		}

		public Task<EnderecoDTO> Remove(EnderecoDTO endereco)
		{
			throw new NotImplementedException();
		}

		public Task<EnderecoDTO> Update(EnderecoDTO endereco)
		{
			throw new NotImplementedException();
		}
	}
}
