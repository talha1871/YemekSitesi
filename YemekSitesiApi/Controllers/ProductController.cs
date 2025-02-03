using AutoMapper;
using Base_Model.Model.Entities;
using Base_Model.Model.ViewModels;
using BL_YemekSitesi.Managers.Abstract;
using DAL_YemekSitesi.Context;
using DtoLayer.Dtos.ProductDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;

        private readonly IMapper _mapper;
        public ProductController(IProductManager productManager, IMapper mapper)
        {
            _productManager = productManager;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ProductList()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productManager.TGetListAll());
            return Ok(values);
        }


        [HttpGet("ProductListWithCategory")]

        public IActionResult ProductListWithCategory()
        {
            SignalRContext context = new SignalRContext();
            var values = context.Products.Include("Category").Select(y => new ResultProductWithCategory
            {
                ProductDescription = y.ProductDescription,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductImage = y.ProductImage,
                ProductPrice = y.ProductPrice,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            });
            //Ürünler Kategorilerle beraber gelecek

            return Ok(values.ToList());

        }

        [HttpPost]

        public IActionResult CreateProduct(CreateProductDto dto)
        {
            var value = _mapper.Map<Product>(dto);
            _productManager.TAdd(value);
            return Ok(value);
        }

        [HttpGet("GetProduct")]

        public IActionResult GetProduct(int id)
        {
            var value = _productManager.TGetByID(id);
            return Ok(value);
        }
        [HttpGet("ProductCount")]
        public IActionResult GetProductCount()
        {
            return Ok(_productManager.TProductCount());
        }
        [HttpGet("ProductCountByCategoryNameAsHamburger")]
        public IActionResult GetProductCountByCategoryNameAsHamburger()
        {
            return Ok(_productManager.TProductCountByCategoryNameAsHamburger());
        }

        [HttpGet("ProductCountByCategoryNameAsDrink")]

        public IActionResult GetProductCountByCategoryNameAsDrink()
        {
            return Ok(_productManager.TProductCountByCategoryNameAsDrink());
        }

        [HttpGet("ProductAvgPrice")]

        public IActionResult GetProductAvgPrice()
        {
            return Ok(_productManager.TProductAvgPrice());
        }

        [HttpGet("ProductNameByMaxPrice")]

        public IActionResult GetProductNameByMaxPrice()
        {
            return Ok(_productManager.TProductNameByMaxPrice());
        }
        [HttpGet("ProductNameByMinPrice")]

        public IActionResult GetProductNameByMinPrice()
        {
            return Ok(_productManager.TProductNameByMinPrice());
        }

        [HttpGet("ProductAvgPriceForHamburger")]
        public IActionResult GetProductAvgPriceForHamburger()
        {
            return Ok(_productManager.TProductAvgPriceForHamburger());
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateProductDto dto)
        {
            var value = _mapper.Map<Product>(dto);
            _productManager.TUpdate(value);
            return Ok("Güncellendi");
        }
       


        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productManager.TGetByID(id);
            _productManager.TDelete(value);
            return Ok("Silindi");
        }
    }
}
