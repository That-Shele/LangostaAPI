using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Plato
{
    public class PlatoDto
    {
        public int IdPlato {get; set;}
        public string NombrePlato {get; set;} = string.Empty;
        public string Descripcion {get; set;} = string.Empty;
        public decimal Costo {get; set;}
        public byte[]? Imagen {get; set;}
    }
}