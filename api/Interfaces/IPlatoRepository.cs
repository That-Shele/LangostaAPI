using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Plato;
using api.Models;

namespace api.Interfaces
{
    public interface IPlatoRepository
    {
        Task <List<Plato>> GetPlatosAsync();
        Task <Plato?> GetPlatoAsync(int id);
        Task <Plato> CreatePlatoAsync(Plato plato);
        Task <Plato?> UpdatePlatoAsync(int id, UpdatePlatoRequestDto updateDto);
        Task <Plato?> DeletePlatoAsync(int id);
    }
}