using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace api.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente {get; set;}
        public string NombreCliente {get; set;} = string.Empty;
        public string Telefono {get; set;} = string.Empty;
        public string Correo {get; set;} = string.Empty;
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

    }
}