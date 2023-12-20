using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Shoopy.Core.Interfaces;
using Shoopy.Core.Models;
using System.Threading.Tasks;

namespace Sh0py.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdcutsController : ControllerBase
    {
        private readonly IGeneric_Repos<Product> _product_Repos;

        public ProdcutsController(IGeneric_Repos<Product> product_Repos)
        {
            _product_Repos = product_Repos;
        }


        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync()
        {
            var product = await _product_Repos.GetByIdAsync(1);
            return product== null ? NotFound() : Ok(product);
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllAsync()
        {
            return Ok(await _product_Repos.GetAllAsync());
        }

        [HttpPost("AddAsync")]
        public async Task<Product> AddAsync()
        {   
            return await _product_Repos.AddAsync(new Product { Name = "Test 4", CategoryId = 1 });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEntity(int id, [FromBody] Product entity)
        {
            await _product_Repos.UpdateAsync(entity);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntity(int id)
        {
            var entity = await _product_Repos.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            await _product_Repos.DeleteAsync(entity);
            return NoContent();
        }

    }
}
