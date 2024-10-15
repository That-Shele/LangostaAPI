using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Dtos.Pedido;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/pedido")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _pedRepo;
        private readonly IClienteRepository _cliRepo;
        public PedidoController(IPedidoRepository pedRepo, IClienteRepository cliRepo)
        {
            _pedRepo = pedRepo;
            _cliRepo = cliRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPedidos() {
            var pedidos = await _pedRepo.GetPedidosAsync();
            var pedidosDto = pedidos.Select(p => p.ToPedidoDto());
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPedido([FromRoute]int id){
            var pedido = await _pedRepo.GetPedidoAsync(id);

            if(pedido == null){
                return NotFound();
            }

            return Ok(pedido.ToPedidoDto());
        }

        [HttpPost]
        public async Task<IActionResult> CreatePedido([FromBody]CreatePedidoRequestDto createDto){
            
            var pedidoModel = createDto.ToCreatePedidoRequestDto();
            await _pedRepo.CreatePedidoAsync(pedidoModel);
            return CreatedAtAction(nameof(GetPedido), new {id = pedidoModel}, pedidoModel.ToPedidoDto());
        }
    }
}