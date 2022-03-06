using System.ComponentModel.DataAnnotations;
public partial class ProductosDetalle
{
    [Key]
    public int Id { get; set; }
    public int ProductoId { get; set; }
    public string? Descripcion { get; set; }

    public string? Presentacion { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }

    public int ExistenciaEmpa { get; set; }

}