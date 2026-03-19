namespace CartaSur.DTOs
{

    /* POST- Este DTO se usa cuando el carrito de compras se confirma en el frontend y se envía al backend para guardarse en la DB
     * Acá no pido IdVenta, FechaVenta, ni ImporteTotal. Por seguridad eso ya es responsabilidad del backend.
    */

    public class VentaCreacionDTO
    {
            public int IdCliente { get; set; }
            public int IdSucursal { get; set; }
            public int IdEmpleado { get; set; }

            // El frontend solo nos dice qué producto se llevó y la cantidad
            public List<DetalleVentaCreacionDTO> Detalles { get; set; } = new List<DetalleVentaCreacionDTO>();
        }

        public class DetalleVentaCreacionDTO
        {
            public int IdProducto { get; set; }
            public int Cantidad { get; set; }
        }

 
}
