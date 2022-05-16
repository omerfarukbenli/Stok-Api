using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stok.Takip.Business.Abstract;
using Stok.Takip.Entities;

namespace Stok.Takip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesesController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoriesesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetCategoryById(id);
        }
        [HttpPost]
        public Category Post([FromBody] Category category)
        {
            return _categoryService.CreateCategory(category);
        }
        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            _categoryService.DeleteCategory(id);
        }
    }
}
