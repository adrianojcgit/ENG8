using ENG8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8.Domain.Interfaces
{
	public interface IClienteRepository
	{
		Task<IEnumerable<Cliente>> GetClientes();
		Task<Cliente> GetById(int? id);
		Task<Cliente> Create(Cliente cliente);
		Task<Cliente> Update(Cliente cliente);
		Task<Cliente> Remove(Cliente cliente);
	}
}
