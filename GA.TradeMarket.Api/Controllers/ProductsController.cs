﻿using GA.TradeMarket.Application.Interfaces;
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
    public sealed class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IProductService productService,ILogger<ProductsController>cont)
        {
            _productService = productService;
            this._logger = cont;
        }

        /// <summary>
        /// Get details about Products -- allowed customer, operator, manager
        /// </summary>
        [HttpGet("All")]
        [Authorize(Roles ="customer,operator,manager")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var products = await _productService.GetAllWithDetailsAsync();
                return Ok(products);
            }
            catch (Exception exp)
            {
                _logger.LogCritical($"error while fetching data:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about product by Id -- allowed customer,operator,manager
        /// </summary>
        [HttpGet("{id:long}")]
        [Authorize(Roles ="customer,operator,manager")]
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
                _logger.LogCritical($"error while fetching data:{exp.Message}");
                return BadRequest(exp);
            }
        }

        /// <summary>
        /// Search products by category and price -- allowed customer,manager,operator
        /// </summary>
        [HttpGet]
        [Authorize(Roles ="customer,manager,operator")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> SearchProducts([FromQuery] long categoryId, [FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
        {
            try
            {
                var res = await _productService.GetAllWithDetailsAsync();
                if (res == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                var rek = res.Where(io => io.ProductCategoryId == categoryId && io.Price >= minPrice && io.Price <= maxPrice).ToList();
                return Ok(rek);
            }
            catch (Exception exp)
            {
                _logger.LogError($"error while searching products: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// add new produt to DB -- allowed operator,manager
        /// </summary>
        [HttpPost]
        [Authorize(Roles ="operator,manager")]
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
                _logger.LogError($"{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update product details in DB -- allowed operator,manager
        /// </summary>
        [HttpPut("{id:long}")]
        [Authorize(Roles = "operator,manager")]
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
                _logger.LogError($"{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// remove product details by id -- allowed operator,manager
        /// </summary>
        [HttpDelete("{id:long}")]
        [Authorize(Roles ="operator,manager")]
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
                _logger.LogError($"{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get all categories  -- allowed customer,operator,manager
        /// </summary>
        [HttpGet("categories")]
        [Authorize(Roles ="operator,manager,customer")]
        public async Task<ActionResult<IEnumerable<ProductCategoryModel>>> GetAllCategories()
        {
            try
            {
                var categories = await _productService.GetAllProductCategoriesAsync();
                return Ok(categories);
            }
            catch (Exception exp)
            {
                _logger.LogError($"{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///add new category to DB -- allowed operator,manager
        /// </summary>
        [HttpPost("categories")]
        [Authorize(Roles = "operator,manager")]
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
                _logger.LogError($"{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///update category to DB -- allowed operator,manager
        /// </summary>
        [HttpPut("categories/{CategoryId:long}")]
        [Authorize(Roles = "operator,manager")]
        public async Task<IActionResult> UpdateCategory([FromRoute] long CategoryId, [FromBody] ProductCategoryModelIn category)
        {
            try
            {

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                await _productService.UpdateCategoryAsync(category);
                return Ok(category);
            }
            catch (Exception exp)
            {
                _logger.LogError($"{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// delete specify category by id -- allowed manager
        /// </summary>
        [HttpDelete("categories/{id:long}")]
        [Authorize(Roles ="manager")]
        public async Task<IActionResult> DeleteCategory([FromRoute] long id)
        {
            try
            {
                await _productService.RemoveCategoryAsync(id);
                return Ok(id);
            }
            catch (Exception exp)
            {
                _logger.LogCritical(exp.Message);
                return BadRequest(exp.Message);
            }
        }

    }
}
