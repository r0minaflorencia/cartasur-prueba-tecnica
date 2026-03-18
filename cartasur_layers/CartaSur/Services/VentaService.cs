using CartaSur.Data;
using Microsoft.EntityFrameworkCore;

namespace CartaSur.Services
{
    public class VentaService
    {
        private readonly AppDbContext _context;

        public VentaService(AppDbContext context)
        {
            _context = context;
        }

        // Método para obtener la fecha con mayor cantidad de ventas
        public async Task<DateTime?> GetFechaConMasVentas()
        {
            var fecha = await _context.Ventas
                // Agrupamos por fecha (ignorando la hora):
                .GroupBy(v => v.FechaVenta.Date)

                // Ordenamos de mayor a menor según la cantidad de ventas
                .OrderByDescending(tickets => tickets.Count())

                // Seleccionamos solo la fecha de ese grupo ganador
                .Select(tickets => tickets.Key)

                // Tomamos el primer resultado (el mayor)
                .FirstOrDefaultAsync();

            return fecha;
        }
    }
}
