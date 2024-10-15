using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Cliente;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;
        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ClienteExists(int id)
        {
            return await _context.Clientes.AnyAsync(x => x.IdCliente == id);
        }

        public async Task<Cliente> CreateClienteAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente?> DeleteClienteAsync(int id)
        {
            var clienteModel = await _context.Clientes.FirstOrDefaultAsync(x => x.IdCliente == id);

            if (clienteModel == null) {
                return null;
            }

            _context.Clientes.Remove(clienteModel);
            await _context.SaveChangesAsync();
            return clienteModel;
        }

        public async Task<Cliente?> GetClienteAsync(int id)
        {
            return await _context.Clientes.Include(p => p.Pedidos).ThenInclude(d => d.Detalle).FirstOrDefaultAsync(i => i.IdCliente == id);
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            return await _context.Clientes.Include(p => p.Pedidos).ThenInclude(d => d.Detalle).ToListAsync();
        }

        public async Task<Cliente?> UpdateClienteAsync(int id, UpdateClienteRequestDto updateDto)
        {
            var clienteModel = await _context.Clientes.FirstOrDefaultAsync(x => x.IdCliente == id);

            if (clienteModel == null) {
                return null;
            }

            clienteModel.NombreCliente = updateDto.NombreCliente;
            clienteModel.Correo = updateDto.Correo;
            clienteModel.Telefono = updateDto.Telefono;
            clienteModel.Pedidos = clienteModel.Pedidos;

             await _context.SaveChangesAsync();
             return clienteModel;
        }
    }
}