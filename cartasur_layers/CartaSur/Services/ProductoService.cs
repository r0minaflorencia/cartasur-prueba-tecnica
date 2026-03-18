using CartaSur.Data;
using CartaSur.Models;
using Microsoft.EntityFrameworkCore;

namespace CartaSur.Services
{
    public class ProductoService
    {
        private readonly AppDbContext _context;

        public ProductoService(AppDbContext context)
        {
            _context = context;
        }

        // Método para obtener todos los productos
        public async Task<List<Producto>> GetAll()
        {
            return await _context.Productos.ToListAsync();
        }
    }
}
