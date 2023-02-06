using ENG8.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using ENG8.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace ENG8.Web.UI.Controllers
{
	[Authorize]
	public class ClientesController : Controller
	{
		private readonly ICLienteService _clienteService;

		public ClientesController(ICLienteService clienteService)
		{
			_clienteService = clienteService;
		}
		
		[HttpPost]
		public async Task<ActionResult> GetClientes()
		{
			var clientesView = await _clienteService.GetClientes();
			return Json(new { data = clientesView });
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[Authorize(Roles = "Admin")]
		[HttpGet()]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(ClienteDTO clienteDto)
		{
			if (ModelState.IsValid)
			{
				await _clienteService.Add(clienteDto);
				return RedirectToAction(nameof(Index));
			}
			return View(clienteDto);
		}

		[HttpGet()]
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null) return NotFound();
			var clienteDto = await _clienteService.GetById(id);
			if (clienteDto == null) return NotFound();
			return View(clienteDto);
		}

		[HttpPost()]
		public async Task<IActionResult> Edit(ClienteDTO clienteDto)
		{
			if (ModelState.IsValid)
			{
				try
				{
					await _clienteService.Update(clienteDto);
				}
				catch (Exception)
				{
					throw;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(clienteDto);
		}

		[HttpGet()]
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
				return NotFound();

			var clienteDto = await _clienteService.GetById(id);

			if (clienteDto == null) return NotFound();

			return View(clienteDto);
		}


		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			await _clienteService.Remove(id);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
				return NotFound();

			var clienteDto = await _clienteService.GetById(id);

			if (clienteDto == null)
				return NotFound();

			return View(clienteDto);
		}
	}
}
