using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Pedido> Pedidos {get; set;}
        public DbSet<PedidoDetalle> PedidosDetalle {get; set;}
        public DbSet<Plato> Platos {get; set;}
    }
}