using AutoMapper;
using CartaSur.DTOs;
using CartaSur.Services;
using Microsoft.AspNetCore.Mvc;

namespace CartaSur.Controllers
{

    [Route("v1/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly ProductoService _service;
        private readonly IMapper _mapper;

        public ProductoController(ProductoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpGet("productos")]
        public async Task<IActionResult> GetProductos()
        {

            var productos = await _service.GetAll();

            if (productos == null)
            {
                return NotFound("No se encontraron productos.");

            }

            var productosDTO = _mapper.Map<List<ProductoDTO>>(productos);

            return Ok(
                new
                {
                    mensaje = "Éxito",
                    productos = productosDTO
                }
            );


        }
    }
}
