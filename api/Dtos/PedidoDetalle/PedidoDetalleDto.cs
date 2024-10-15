using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.PedidoDetalle
{
    public class PedidoDetalleDto
    {
        public int IdPedidoDetalle {get; set;}
        public string Plato {get; set;} = string.Empty;
        public decimal PrecioPlato {get; set;}
        public DateTime FechaPedido {get; set;}
        public int IdPedido {get; set;}
        
    }
}