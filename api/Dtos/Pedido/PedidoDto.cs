using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Pedido
{
    public class PedidoDto
    {
        public int IdPedido {get; set;}
        
        public decimal PrecioPedido {get; set;}
        public DateTime FechaPedido {get; set;}
        public int IdCliente {get; set;}
        
    }
}