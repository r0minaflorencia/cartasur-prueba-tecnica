using AutoMapper;
using CartaSur.DTOs;
using CartaSur.Models;

namespace CartaSur.Mappers
{
    public class ProductoMapper : Profile
    {
        public ProductoMapper()
        {
            // Mapeo de Entidad (Model) a DTO (Lectura / GET)
            CreateMap<Producto, ProductoDTO>();

        }
    }
}
