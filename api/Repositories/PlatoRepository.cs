using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Plato;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class PlatoRepository : IPlatoRepository
    {
        private readonly ApplicationDbContext _context;
        public PlatoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Plato> CreatePlatoAsync(Plato plato)
        {
            await _context.AddAsync(plato);
            await _context.SaveChangesAsync();
            return plato;
        }

        public async Task<List<Plato>> GetPlatosAsync()
        {
            return await _context.Platos.ToListAsync();
        }

        public async Task<Plato?> GetPlatoAsync(int id)
        {
            return await _context.Platos.FirstOrDefaultAsync(x => x.IdPlato == id);
        }

        public async Task<Plato?> UpdatePlatoAsync(int id, UpdatePlatoRequestDto updateDto)
        {
            var platoModel = await _context.Platos.FirstOrDefaultAsync(x => x.IdPlato == id);

            if(platoModel == null) {
                return null;
            }

            platoModel.NombrePlato = updateDto.NombrePlato;
            platoModel.Costo = updateDto.Costo;
            platoModel.Descripcion = updateDto.Descripcion;
            platoModel.Imagen = updateDto.Imagen;
            
            await _context.SaveChangesAsync();
            return platoModel;
        }

        public async Task<Plato?> DeletePlatoAsync(int id)
        {
            var platoModel = await _context.Platos.FirstOrDefaultAsync(x => x.IdPlato == id);

            if(platoModel == null) {
                return null;
            }

            _context.Platos.Remove(platoModel);
            await _context.SaveChangesAsync();
            return platoModel;
        }

        
    }
}