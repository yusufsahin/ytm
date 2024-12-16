using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStore.BAL.Abstract;

namespace SportsStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        public readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult SaveProduct()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }
    }
}
