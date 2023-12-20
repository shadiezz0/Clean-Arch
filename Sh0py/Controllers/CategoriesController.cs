using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoopy.Core.Interfaces;
using Shoopy.Core.Models;

namespace Sh0py.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IGeneric_Repos<Category> _cat_Repos;

        public CategoriesController(IGeneric_Repos<Category> cat_Repos)
        {
            _cat_Repos = cat_Repos;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync()
        {
            return Ok(await _cat_Repos.GetByIdAsync(1));
        }
    }
}
