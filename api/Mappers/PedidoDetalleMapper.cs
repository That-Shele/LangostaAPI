using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.PedidoDetalle;
using api.Models;

namespace api.Mappers
{
    public static class PedidoDetalleMapper
    {
        public static PedidoDetalleDto ToPedidoDetalleDto(this PedidoDetalle detalleModel, int id) {
            return new PedidoDetalleDto {
                IdPedidoDetalle = detalleModel.IdPedidoDetalle,
                Plato = detalleModel.Plato,
                PrecioPlato = detalleModel.PrecioPlato,
                FechaPedido = detalleModel.FechaPedido,
                IdPedido = id
            };
        }
    }
}