using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido {get; set;}
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioPedido {get; set;}
        public List<PedidoDetalle>? Detalle {get; set;}

        
        public int IdCliente {get; set;}
        [ForeignKey("IdCliente")]
        [JsonIgnore]
        public virtual Cliente? Cliente {get; set;}
    }
}