using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Dtos.Cliente;
using api.Models;

namespace api.Mappers
{
    public static class ClienteMapper
    {
        public static ClienteDto ToClienteDto(this Cliente cliente) {
            return new ClienteDto{
                IdCliente = cliente.IdCliente,
                NombreCliente = cliente.NombreCliente,
                Correo = cliente.Correo,
                Telefono = cliente.Telefono,
                Pedidos = cliente.Pedidos.Select(p => p.ToPedidoDto()).ToList()
            };
        }

        public static Cliente ToCreateClienteRequestDto(this CreateClienteRequestDto ccrd) {
            return new Cliente {
                NombreCliente = ccrd.NombreCliente,
                Correo = ccrd.Correo,
                Telefono = ccrd.Telefono
            };
        }
    }
}