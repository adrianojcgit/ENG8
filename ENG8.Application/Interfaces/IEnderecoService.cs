using ENG8.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8.Application.Interfaces
{
	public interface IEnderecoService
	{
		Task<IEnumerable<EnderecoDTO>> GetEnderecos();
		Task<EnderecoDTO> GetById(int? id);
		Task<EnderecoDTO> Create(EnderecoDTO endereco);
		Task<EnderecoDTO> Update(EnderecoDTO endereco);
		Task<EnderecoDTO> Remove(EnderecoDTO endereco);
	}
}
