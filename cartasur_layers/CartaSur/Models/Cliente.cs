using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CartaSur.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [Column("dni")]
        public string Dni { get; set; } = string.Empty;

        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("direccion_envio")]
        public string DireccionEnvio { get; set; } = string.Empty;
        public List<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
