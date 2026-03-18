using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CartaSur.Models
{
    [Table("detalle_ventas")]
    public class DetalleVenta
    {
        [Key]
        [Column("id_detalle")]
        public int IdDetalle { get; set; }

        [Column("id_venta")]
        public int IdVenta { get; set; }

        [Column("id_producto")]
        public int IdProducto { get; set; }

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("precio_unitario_en_momento_venta")]
        public decimal PrecioUnitarioEnMomentoVenta { get; set; }

        [ForeignKey("IdVenta")]
        public Venta Venta { get; set; }

        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; }
    }
}
