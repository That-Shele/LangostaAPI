using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Plato;
using api.Models;

namespace api.Mappers
{
    public static class PlatoMapper
    {
        public static PlatoDto ToPlatoDto(this Plato plato) {
            return new PlatoDto {
                IdPlato = plato.IdPlato,
                NombrePlato = plato.NombrePlato,
                Costo = plato.Costo,
                Descripcion = plato.Descripcion,
                Imagen = plato.Imagen
            };
        }

        public static Plato ToCreatePlatoRequestDto(this CreatePlatoRequestDto cprd) {
            return new Plato {
                NombrePlato = cprd.NombrePlato,
                Costo = cprd.Costo,
                Descripcion = cprd.Descripcion,
                Imagen = cprd.Imagen
            };
        }
    }
}