using ENG8.Application.DTOs;
using ENG8.Application.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8.Application.Interfaces
{
	public interface ICLienteService
	{
		Task<IEnumerable<ClienteView>> GetClientes();
		Task<ClienteDTO> GetById(int? id);
		Task Add(ClienteDTO categoryDto);
		Task Update(ClienteDTO categoryDto);
		Task Remove(int? id);
	}
}
