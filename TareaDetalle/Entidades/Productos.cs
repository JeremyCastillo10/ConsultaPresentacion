using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TareaDetalle.Entidades
{
    public partial class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio debe indicar la descripción.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Range(0.1, int.MaxValue, ErrorMessage = "Se debe indicar la existencia del producto dentro de los rangos {1}/{2}.")]
        public double Existencia { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El costo debe estar dentro del rango permitido")]
        public double Costo { get; set; }
        

        public double ValorInventario { get; set; }

        public int ExistenciaEmpa { get; set; }
        public double Precio { get; set; }
        [Required(ErrorMessage = "Campo obligatorio.")]

        public DateTime FechaCaducidad { get; set; }
        public string? Presentacion { get; set; }
        public int Ganancia { get; set; }

        [ForeignKey("ProductoId")]

        public virtual List<ProductosDetalle> ProductosDetalle {get;set;}= new List<ProductosDetalle>();
    }
}