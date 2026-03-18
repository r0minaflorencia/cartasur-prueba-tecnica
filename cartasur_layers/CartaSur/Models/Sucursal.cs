using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CartaSur.Models
{
    [Table("sucursales")]
    public class Sucursal
    {
        [Key]
        [Column("id_sucursal")]
        public int IdSucursal { get; set; }

        [Column("nombre_sucursal")]
        public string NombreSucursal { get; set; } = string.Empty;

        [Column("direccion_sucursal")]
        public string DireccionSucursal { get; set; } = string.Empty;

        public List<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
