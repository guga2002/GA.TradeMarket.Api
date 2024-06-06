using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// Get details about Products
        /// </summary>
        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var products = await _productService.GetAllWithDetailsAsync();
                return Ok(products);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about product by Id
        /// </summary>
        [HttpGet("{id:long}")]
        public async Task<ActionResult<ProductModel>> GetByIdAsync([FromRoute]long id)
        {
            try
            {
                var product = await _productService.GetByIdAsync(id);
                if (product == null || product.ProductName is null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(product);
            }
            catch (MarketException exp)
            {
                return BadRequest(exp);
            }
        }

        /// <summary>
        /// Search products by category and price
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> SearchProducts([FromQuery] long categoryId, [FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
        {
            try
            {
                var res = await _productService.GetAllWithDetailsAsync();
                if (res == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                if (maxPrice != 50)
                {
                    return Ok(res);
                }
                var rek = res.Where(io => io.ProductCategoryId == categoryId && io.Price >= minPrice && io.Price <= maxPrice).ToList();
                return Ok(rek);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// add new produt to DB
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody]ProductModelIn product)
        {
            try
            {
                if (!ModelState.IsValid || string.IsNullOrEmpty(product.ProductName))
                    return BadRequest(ErrorKeys.BadRequest);
                await _productService.AddAsync(product);
                return Ok(product);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update product details in DB
        /// </summary>
        [HttpPut("{id:long}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] long id, [FromBody] ProductModelIn product)
        {
            try
            {
                if (id != product.Id)
                    return BadRequest(ErrorKeys.BadRequest);
                if (!ModelState.IsValid || string.IsNullOrEmpty(product.ProductName))
                {
                    return BadRequest(ModelState);
                }
                await _productService.UpdateAsync(product);
                return Ok(id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// remove product details by id
        /// </summary>
        [HttpDelete("{id:long}")]
        public async Task<IActionResult> DeleteProduct([FromRoute]long id)
        {
            try
            {
                var existingProduct = await _productService.GetByIdAsync(id);
                if (existingProduct == null)
                    return NotFound(ErrorKeys.NotFound);

                await _productService.DeleteAsync(id);
                return Ok(id);
            }
            catch (Exception exp)
            {

                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get all categories 
        /// </summary>
        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<ProductCategoryModel>>> GetAllCategories()
        {
            try
            {
                var categories = await _productService.GetAllProductCategoriesAsync();
                return Ok(categories);
            }
            catch (Exception exp)
            {

                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///add new category to DB
        /// </summary>
        [HttpPost("categories")]
        public async Task<ActionResult<ProductCategoryModel>> AddCategory([FromBody] ProductCategoryModelIn category)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                await _productService.AddCategoryAsync(category);
                return CreatedAtAction(nameof(GetAllCategories), new { id = category.Id }, category);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///update category to DB
        /// </summary>
        [HttpPut("categories/{id:long}")]
        public async Task<IActionResult> UpdateCategory([FromRoute] long id, [FromBody] ProductCategoryModelIn category)
        {
            try
            {
                if (id != category.Id)
                    return BadRequest(ErrorKeys.BadRequest);

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                await _productService.UpdateCategoryAsync(category);
                return Ok(category);
            }
            catch (Exception exp)
            {

                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// delete specify category by id
        /// </summary>
        [HttpDelete("categories/{id:long}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] long id)
        {
            try
            {
                await _productService.RemoveCategoryAsync(id);
                return Ok(id);
            }
            catch (Exception exp)
            {

                return BadRequest(exp.Message);
            }
        }

    }
}
