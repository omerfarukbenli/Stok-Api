using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stok.Takip.Business.Abstract;
using Stok.Takip.Entities;

namespace Stok.Takip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsesController : ControllerBase
    {
        private IProductService _productService;
        public ProductsesController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }
        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return _productService.CreateProduct(product);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
