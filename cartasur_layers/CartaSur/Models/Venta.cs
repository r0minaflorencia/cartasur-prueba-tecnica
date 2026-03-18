using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CartaSur.Models
{
    [Table("ventas")]
    public class Venta
    {
        [Key]
        [Column("id_venta")]
        public int IdVenta { get; set; }

        [Column("fecha_venta")]
        public DateTime FechaVenta { get; set; }

        [Column("id_cliente")]
        public int IdCliente { get; set; } 

        [Column("id_sucursal")]
        public int IdSucursal { get; set; }

        [Column("id_empleado")]
        public int IdEmpleado { get; set; }

        [Column("importe_total")]
        public decimal ImporteTotal { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; } 

        [ForeignKey("IdSucursal")]
        public Sucursal Sucursal { get; set; } 

        [ForeignKey("IdEmpleado")]
        public Empleado Empleado { get; set; }

        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }
}
