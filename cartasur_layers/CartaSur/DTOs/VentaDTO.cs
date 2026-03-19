namespace CartaSur.DTOs
{

    /* GET- Este DTO es de lectura, por ejemplo para cuando Angular pida el historial de ventas */

 public class VentaDTO
    {
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal ImporteTotal { get; set; }
        public string NombreCliente { get; set; } 
        public string NombreSucursal { get; set; }
        public string NombreEmpleado { get; set; }
        public List<DetalleVentaDTO> Detalles { get; set; } = new List<DetalleVentaDTO>();
    }

    public class DetalleVentaDTO
    {
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }

}
