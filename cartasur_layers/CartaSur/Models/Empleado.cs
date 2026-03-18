using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CartaSur.Models
{
    [Table("empleados")]
    public class Empleado
    {
        [Key]
        [Column("id_empleado")]
        public int IdEmpleado { get; set; }

        [Column("nombre_empleado")]
        public string NombreEmpleado { get; set; } = string.Empty;

        public List<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
