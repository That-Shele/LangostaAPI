using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Plato
    {
        [Key]
        public int IdPlato {get; set;}
        public string NombrePlato {get; set;} = string.Empty;
        public string Descripcion {get; set;} = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Costo {get; set;}
        public byte[]? Imagen {get; set;}
    }
}