using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationDbContext _context;
        public PedidoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Pedido> CreatePedidoAsync(Pedido pedidoModel)
        {
            await _context.Pedidos.AddAsync(pedidoModel);
            await _context.SaveChangesAsync();
            return pedidoModel;
        }

        public async Task<Pedido?> GetPedidoAsync(int id)
        {
            return await _context.Pedidos.FirstOrDefaultAsync(i => i.IdPedido == id);
        }

        public async Task<List<Pedido>> GetPedidosAsync()
        {
            return await _context.Pedidos.ToListAsync();
        }

        public async Task<List<Pedido>> GetPedidosClienteAsync(int id) {
            return await _context.Pedidos.Where(x => x.IdCliente == id).ToListAsync();
        }
    }
}