using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Pedido;


namespace api.Dtos.Cliente
{
    public class ClienteDto
    {
        public int IdCliente {get; set;}
        public string NombreCliente {get; set;} = string.Empty;
        public string Telefono {get; set;} = string.Empty;
        public string Correo {get; set;} = string.Empty;
        public List<PedidoDto>? Pedidos { get; set; }

    }
}