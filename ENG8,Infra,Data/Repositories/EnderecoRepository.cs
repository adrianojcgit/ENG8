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
	public class EnderecoRepository : IEnderecoRepository
	{
		private readonly ApplicationDbContext _enderecoContext;

		public EnderecoRepository(ApplicationDbContext enderecoContext)
		{
			_enderecoContext = enderecoContext;
		}

		public async Task<Endereco> Create(Endereco endereco)
		{
			_enderecoContext.Add(endereco);
			await _enderecoContext.SaveChangesAsync();
			return endereco;
		}

		public async Task<Endereco> GetById(int? id)
		{
			return await _enderecoContext.Enderecos.FindAsync(id);
		}

		public async Task<IEnumerable<Endereco>> GetEnderecos()
		{
			return await _enderecoContext.Enderecos.ToListAsync();
		}

		public async Task<Endereco> Remove(Endereco endereco)
		{
			_enderecoContext.Remove(endereco);
			await _enderecoContext.SaveChangesAsync();
			return endereco;
		}

		public async Task<Endereco> Update(Endereco endereco)
		{
			_enderecoContext.Update(endereco);
			await _enderecoContext.SaveChangesAsync();
			return endereco;
		}
	}
}
