using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Cliente
{
    public class UpdateClienteRequestDto
    {
        public string NombreCliente {get; set;} = string.Empty;
        public string Telefono {get; set;} = string.Empty;
        public string Correo {get; set;} = string.Empty;
    }
}