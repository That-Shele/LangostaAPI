using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace api.Dtos.Pedido
{
    public class CreatePedidoRequestDto
    {
        public decimal PrecioPedido {get; set;}
        public DateTime FechaPedido {get; set;}
        public int IdCliente {get; set;}
    }
}