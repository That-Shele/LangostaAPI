using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos;
using api.Dtos.Cliente;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _cliRepo;
        public ClienteController( IClienteRepository cliRepo)
        {
            _cliRepo = cliRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes() {
            var clientes = await _cliRepo.GetClientesAsync();
            var clientesDto = clientes.Select(c => c.ToClienteDto());
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCliente([FromRoute] int id) {
            var cliente = await _cliRepo.GetClienteAsync(id);

            if (cliente == null) {
                return NotFound();
            }

            return Ok(cliente.ToClienteDto());
        }

        [HttpPost]
        public async Task<IActionResult> CreateCliente([FromBody] CreateClienteRequestDto createDto) {
            var clienteModel = createDto.ToCreateClienteRequestDto();
            await _cliRepo.CreateClienteAsync(clienteModel);
            return CreatedAtAction(nameof(GetCliente), new {id = clienteModel.IdCliente}, clienteModel.ToClienteDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateCliente([FromRoute] int id, [FromBody] UpdateClienteRequestDto updateDto) {
            var clienteModel = await _cliRepo.UpdateClienteAsync(id, updateDto);

            if (clienteModel == null) {
                return NotFound();
            }

            return Ok(clienteModel.ToClienteDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteCliente([FromRoute] int id) {
            var clienteModel = await _cliRepo.DeleteClienteAsync(id);

            if (clienteModel == null) {
                return NotFound();
            }

            return NoContent();
        }
    }
}