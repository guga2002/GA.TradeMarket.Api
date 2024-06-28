using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductsController> _logger;
        private readonly IMemoryCache cashe;
        public ProductsController(IProductService productService,ILogger<ProductsController>cont,IMemoryCache cash)
        {
            _productService = productService;
            this._logger = cont;
            this.cashe = cash;
        }

        /// <summary>
        /// Get details about Products 
        /// </summary>
        /// <remarks>
        /// allowed customer, operator, manager -- **enable cashing**
        /// </remarks>
        [HttpGet("All")]
        [Authorize(Roles = "customer,operator,manager")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetAllWithDetailsAsync()
        {
            var key = "GetAllProducts";
            if (cashe.TryGetValue(key, out IEnumerable<ProductModel>? products))
            {
                if (products is not null)
                {
                    return Ok(products);
                }
            }
            var productsFromDB = await _productService.GetAllWithDetailsAsync();
            if (productsFromDB.Any())
            {
                cashe.Set(key, productsFromDB, TimeSpan.FromMinutes(10));
                return Ok(products);
            }
            return NotFound(ErrorKeys.NotFound);
        }

        /// <summary>
        /// Get details about product by Id 
        /// </summary>
        /// <remarks>
        ///  allowed customer,operator,manager -- **enable cashing**
        /// </remarks>
        [HttpGet("{id:long}")]
        [Authorize(Roles = "customer,operator,manager")]
        public async Task<ActionResult<ProductModel>> GetByIdAsync([FromRoute] long id)
        {
            var cashedkey = $"GetProduct{id}";
            if (cashe.TryGetValue(id, out ProductModel? products))
            {
                if (products is not null)
                {
                    return Ok(products);
                }
            }

            var product = await _productService.GetByIdAsync(id);
            if (product == null || product.ProductName is null)
            {
                return NotFound(ErrorKeys.NotFound);
            }
            cashe.Set(cashedkey, product, TimeSpan.FromMinutes(10));
            return Ok(product);
        }

        /// <summary>
        /// Search products by category and price 
        /// </summary>
        /// <remarks>
        ///  allowed **customer,manager,operator**
        /// </remarks>
        [HttpGet]
        [Authorize(Roles = "customer,manager,operator")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> SearchProducts([FromQuery] long categoryId, [FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
        {
            var res = await _productService.GetAllWithDetailsAsync();
            if (res == null)
            {
                return NotFound(ErrorKeys.NotFound);
            }
            var rek = res.Where(io => io.ProductCategoryId == categoryId && io.Price >= minPrice && io.Price <= maxPrice).ToList();
            return Ok(rek);
        }

        /// <summary>
        /// add new produt to DB 
        /// </summary>
        /// <remarks>
        /// allowed **operator,manager**
        /// </remarks>
        [HttpPost]
        [Authorize(Roles = "operator,manager")]
        public async Task<IActionResult> AddProduct([FromBody] ProductModelIn product)
        {

            if (!ModelState.IsValid || string.IsNullOrEmpty(product.ProductName))
                return BadRequest(ErrorKeys.BadRequest);
            await _productService.AddAsync(product);
            return Ok(product);
        }

        /// <summary>
        /// update product details in DB 
        /// </summary>
        /// <remarks>
        /// allowed **operator,manager**
        /// </remarks>
        [HttpPut("{id:long}")]
        [Authorize(Roles = "operator,manager")]
        public async Task<IActionResult> UpdateProduct([FromRoute] long id, [FromBody] ProductModelIn product)
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

        /// <summary>
        /// remove product details by id 
        /// </summary>
        /// <remarks>
        /// allowed **operator,manager**
        /// </remarks>
        [HttpDelete("{id:long}")]
        [Authorize(Roles = "operator,manager")]
        public async Task<IActionResult> DeleteProduct([FromRoute] long id)
        {
            var existingProduct = await _productService.GetByIdAsync(id);
            if (existingProduct == null)
                return NotFound(ErrorKeys.NotFound);

            await _productService.DeleteAsync(id);
            return Ok(id);
        }

        /// <summary>
        /// Get all categories  
        /// </summary>
        /// <remarks>
        ///  allowed customer,operator,manager  -- **enable cashing**
        /// </remarks>
        [HttpGet("categories")]
        [Authorize(Roles = "operator,manager,customer")]
        public async Task<ActionResult<IEnumerable<ProductCategoryModel>>> GetAllCategories()
        {
            string cashedkey = "GetAllCategories";
            if (cashe.TryGetValue(cashedkey, out ProductCategoryModel? category))
            {
                if (category is not null)
                {
                    return Ok(category);
                }
            }
            var categories = await _productService.GetAllProductCategoriesAsync();
            cashe.Set(cashedkey, categories, TimeSpan.FromMinutes(10));
            return Ok(categories);
        }

        /// <summary>
        ///add new category to DB 
        /// </summary>
        /// <remarks>
        /// allowed **operator,manager**
        /// </remarks>
        [HttpPost("categories")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<ProductCategoryModel>> AddCategory([FromBody] ProductCategoryModelIn category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _productService.AddCategoryAsync(category);
            return CreatedAtAction(nameof(GetAllCategories), new { id = category.Id }, category);
        }

        /// <summary>
        ///update category to DB 
        /// </summary>
        /// <remarks>
        ///  allowed **operator,manager**
        /// </remarks>
        [HttpPut("categories/{CategoryId:long}")]
        [Authorize(Roles = "operator,manager")]
        public async Task<IActionResult> UpdateCategory([FromRoute] long CategoryId, [FromBody] ProductCategoryModelIn category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _productService.UpdateCategoryAsync(category);
            return Ok(category);
        }

        /// <summary>
        /// delete specify category by id 
        /// </summary>
        /// <remarks>
        /// allowed **manager**
        /// </remarks>
        [HttpDelete("categories/{id:long}")]
        [Authorize(Roles = "manager")]
        public async Task<IActionResult> DeleteCategory([FromRoute] long id)
        {
            await _productService.RemoveCategoryAsync(id);
            return Ok(id);

        }

    }
}
