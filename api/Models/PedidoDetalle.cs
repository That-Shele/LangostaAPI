using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace api.Models
{
    public class PedidoDetalle
    {
        [Key]
        [JsonIgnore]
        public int IdPedidoDetalle {get; set;}
        public string Plato {get; set;} = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioPlato {get; set;}
        public DateTime FechaPedido {get; set;}

        public int IdPedido {get; set;}
        [ForeignKey("IdPedido")]
        [JsonIgnore]
        public virtual Pedido? Pedido {get; set;}
        

    }
}