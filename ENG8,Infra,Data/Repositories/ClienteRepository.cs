using ENG8.Domain.Entities;
using ENG8.Domain.Interfaces;
using ENG8_Infra_Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8_Infra_Data.Repositories
{
	public class ClienteRepository : IClienteRepository
	{
		private readonly ApplicationDbContext _clienteContext;

		public ClienteRepository(ApplicationDbContext clienteContext)
		{
			_clienteContext = clienteContext;
		}

		public async Task<Cliente> Create(Cliente cliente)
		{
			_clienteContext.Add(cliente);
			await _clienteContext.SaveChangesAsync();
			return cliente;
		}

		public async Task<Cliente> GetById(int? id)
		{
			return await _clienteContext.Clientes.FindAsync(id);
		}

		public async Task<IEnumerable<Cliente>> GetClientes()
		{
			return await _clienteContext.Clientes.ToListAsync();
		}

		public async Task<Cliente> Remove(Cliente cliente)
		{
			_clienteContext.Remove(cliente);
			await _clienteContext.SaveChangesAsync();
			return cliente;
		}

		public async Task<Cliente> Update(Cliente cliente)
		{
			_clienteContext.Update(cliente);
			await _clienteContext.SaveChangesAsync();
			return cliente;
		}
	}
}
