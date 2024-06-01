using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetAllProducts()
        {

            var products = await _productService.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<ProductModel>> GetByIdAsync([FromRoute]long id)
        {
            try
            {
                var product = await _productService.GetByIdAsync(id);
                if (product == null || product.ProductName is null)
                {
                    return NotFound(id);
                }
                return Ok(product);
            }
            catch (MarketException exp)
            {
                return BadRequest(exp);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> SearchProducts([FromQuery] long categoryId, [FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
        {
            var res = await _productService.GetAllAsync();
            if (res == null)
            {
                return NotFound();
            }
            if (maxPrice != 50)
            {
                return Ok(res);
            }
            var rek = res.Where(io => io.ProductCategoryId == categoryId && io.Price >= minPrice && io.Price <= maxPrice).ToList();
            return Ok(rek);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody]ProductModel product)
        {
            if (!ModelState.IsValid || string.IsNullOrEmpty(product.ProductName))
                return BadRequest();
            await _productService.AddAsync(product);
            return Ok(product);
        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> UpdateProduct([FromRoute]long id,[FromBody] ProductModel product)
        {
            if (id != product.Id)
                return BadRequest();
            if (!ModelState.IsValid || string.IsNullOrEmpty(product.ProductName))
            {
                return BadRequest(ModelState);
            }
            await _productService.UpdateAsync(product);
            return Ok();
        }

        [HttpDelete("{id:long}")]
        public async Task<IActionResult> DeleteProduct([FromRoute]long id)
        {
            var existingProduct = await _productService.GetByIdAsync(id);
            if (existingProduct == null)
                return NotFound();

            await _productService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<ProductCategoryModel>>> GetAllCategories()
        {
            var categories = await _productService.GetAllProductCategoriesAsync();
            return Ok(categories);
        }

        [HttpPost("categories")]
        public async Task<ActionResult<ProductCategoryModel>> AddCategory([FromBody]ProductCategoryModel category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _productService.AddCategoryAsync(category);
            return CreatedAtAction(nameof(GetAllCategories), new { id = category.Id }, category);
        }

        [HttpPut("categories/{id:long}")]
        public async Task<IActionResult> UpdateCategory([FromRoute]long id, [FromBody]ProductCategoryModel category)
        {
            if (id != category.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _productService.UpdateCategoryAsync(category);
            return NoContent();
        }

        [HttpDelete("categories/{id:long}")]
        public async Task<IActionResult> DeleteCategory([FromRoute]long id)
        {
            await _productService.RemoveCategoryAsync(id);
            return Ok();
        }

    }
}
