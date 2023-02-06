using ENG8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8.Domain.Interfaces
{
	public interface IEnderecoRepository
	{
		Task<IEnumerable<Endereco>> GetEnderecos();
		Task<Endereco> GetById(int? id);
		Task<Endereco> Create(Endereco endereco);
		Task<Endereco> Update(Endereco endereco);
		Task<Endereco> Remove(Endereco endereco);
	}
}
