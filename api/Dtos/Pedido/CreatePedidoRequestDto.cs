using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.PedidoDetalle;
namespace api.Dtos.Pedido
{
    public class CreatePedidoRequestDto
    {
        public decimal PrecioPedido {get; set;}
        public List<Models.PedidoDetalle>? Detalle {get; set;}
        public int IdCliente {get; set;}
    }
}