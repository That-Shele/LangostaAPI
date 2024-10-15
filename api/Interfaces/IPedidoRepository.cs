using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface IPedidoRepository
    {
        Task <List<Pedido>> GetPedidosAsync();
        Task <Pedido?> GetPedidoAsync(int id);
        Task <List<Pedido>> GetPedidosClienteAsync(int id);
        Task <Pedido> CreatePedidoAsync(Pedido pedidoModel);
    }
}