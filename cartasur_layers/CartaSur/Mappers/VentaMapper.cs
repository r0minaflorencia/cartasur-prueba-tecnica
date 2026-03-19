using AutoMapper;
using CartaSur.Models;
using CartaSur.DTOs;

namespace CartaSur.Mappers
{
    public class VentaMapper : Profile
    {
        public VentaMapper() {

            // Mapeo de Entidad a DTO (Lectura - GET)
            CreateMap<Venta, VentaDTO>()
                .ForMember(destino => destino.NombreCliente,
                           opciones => opciones.MapFrom(origen => origen.Cliente.Nombre))
                .ForMember(destino => destino.NombreSucursal,
                           opciones => opciones.MapFrom(origen => origen.Sucursal.NombreSucursal))
                .ForMember(destino => destino.NombreEmpleado,
                           opciones => opciones.MapFrom(origen => origen.Empleado.NombreEmpleado));

            CreateMap<DetalleVenta, DetalleVentaDTO>()
                .ForMember(destino => destino.NombreProducto,
                           opciones => opciones.MapFrom(origen => origen.Producto.NombreProducto));

            // Mapeo de DTO a Entidad (Creación - POST)
            CreateMap<VentaCreacionDTO, Venta>();
            CreateMap<DetalleVentaCreacionDTO, DetalleVenta>();
        }
    }

}
