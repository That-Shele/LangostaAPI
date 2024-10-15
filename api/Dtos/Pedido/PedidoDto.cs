using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.PedidoDetalle;

namespace api.Dtos.Pedido
{
    public class PedidoDto
    {
        public int IdPedido {get; set;}
        
        public decimal PrecioPedido {get; set;}
        public List<PedidoDetalleDto>? Detalle {get; set;}
        public int IdCliente {get; set;}
        
    }
}