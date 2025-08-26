using Microsoft.AspNetCore.Mvc;

namespace Product.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context =context;
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductModel>> GetItem(int id)
        {
            _context.Database.EnsureCreated();

            var item = await _context.Products.FindAsync(id);

            if (item == null)
                return NotFound();

            return item;
        }
    }
}
