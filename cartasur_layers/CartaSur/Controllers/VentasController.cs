using CartaSur.Services;
using Microsoft.AspNetCore.Mvc;

namespace CartaSur.Controllers
{
  
    [Route("v1/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly VentaService _service;

        // Inyeccion del servicio por el constructor
        public VentasController(VentaService ventaService)
        {
            _service = ventaService;
        }

        // endpoint
        [HttpGet("mejor-fecha")]
        public async Task<IActionResult> GetMejorFecha()
        {
            var fecha = await _service.GetFechaConMasVentas();

            if (fecha == null)
            {
                return NotFound("No se encontraron ventas.");
            }

            // Devuelvo un objeto generico que se convertirá en JSON:
            return Ok(new
            {
                mensaje = "Éxito",
                fechaConMasVentas = fecha.Value.ToShortDateString()
            }); 
        }
    }
}
