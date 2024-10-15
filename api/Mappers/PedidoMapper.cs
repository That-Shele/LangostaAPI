using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Pedido;
using api.Models;

namespace api.Mappers
{
    public static class PedidoMapper
    {
        public static PedidoDto ToPedidoDto(this Pedido pedidoModel) {
            return new PedidoDto {
                IdPedido = pedidoModel.IdPedido,
                PrecioPedido = pedidoModel.PrecioPedido,
                FechaPedido = pedidoModel.FechaPedido,
                IdCliente = pedidoModel.IdCliente
            };
        }

        public static Pedido ToCreatePedidoRequestDto(this CreatePedidoRequestDto cprd) {
     

            return new Pedido {
                PrecioPedido = cprd.PrecioPedido,
                FechaPedido = cprd.FechaPedido,
                IdCliente = cprd.IdCliente
            };
        }
    
    }
}