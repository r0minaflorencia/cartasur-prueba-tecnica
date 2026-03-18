using CartaSur.Services;
using Microsoft.AspNetCore.Mvc;

namespace CartaSur.Controllers
{


    [Route("v1/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly ProductoService _service;

        public ProductoController(ProductoService service)
        {
            _service = service;
        }


        [HttpGet("productos")]
        public async Task<IActionResult> GetProductos()
        {

            var productos = await _service.GetAll();

            if (productos == null)
            {
                return NotFound("No se encontraron productos.");

            }
            return Ok(
                new
                {
                    mensaje = "Éxito",
                    productos = productos.ToList()
                }
            );


        }
    }
}
