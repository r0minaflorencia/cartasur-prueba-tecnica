using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CartaSur.Models
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        [Column("id_producto")]
        public int IdProducto { get; set; }

        [Column("nombre_producto")]
        public string NombreProducto { get; set; } = string.Empty;

        [Column("precio_unitario")]
        public decimal PrecioUnitario { get; set; }

        public List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
    }
}
