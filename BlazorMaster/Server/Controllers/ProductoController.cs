using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BlazorMaster.Server.Models;
using Microsoft.EntityFrameworkCore;
using BlazorMaster.Shared;

namespace BlazorMaster.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DbpruebaContext _dbContext;

        public ProductoController(DbpruebaContext dbContext)
        {
            _dbContext = dbContext; ;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var lista = new List<ProductoDTO>();

            foreach(var item in await _dbContext.Productos.ToListAsync())
            {
                lista.Add(new ProductoDTO
                {
                    IdProducto = item.IdProducto,
                    Nombre = item.Nombre,
                    Precio = item.Precio
                });
            }

            return Ok(lista);
        }

    }
}
