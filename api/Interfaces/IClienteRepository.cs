using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Cliente;
using api.Models;

namespace api.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetClientesAsync();
        Task<Cliente?> GetClienteAsync(int id);
        Task<Cliente> CreateClienteAsync(Cliente cliente);
        Task<Cliente?> UpdateClienteAsync(int id, UpdateClienteRequestDto updateDto);
        Task<Cliente?> DeleteClienteAsync(int id);
        Task<bool> ClienteExists(int id);
    }
}