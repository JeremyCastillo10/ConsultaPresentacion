using Microsoft.EntityFrameworkCore;
using TareaDetalle.Entidades;

namespace TareaDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos {get; set;}
        public DbSet<ProductosDetalle> ProductosDetalles {get; set;}
        
        public Contexto(DbContextOptions<Contexto> options) : base(options){}

    }
}
