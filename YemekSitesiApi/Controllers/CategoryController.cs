using AutoMapper;
using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using DtoLayer.Dtos.CategoryDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Design;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;

        private readonly IMapper _mapper;
        public CategoryController(ICategoryManager categoryManager, IMapper mapper)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
        }

        [HttpGet] // **

        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<ResultCategoryDto>>(_categoryManager.TGetListAll());
            return Ok(values);
        }
        [HttpPost] // *

        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            createCategoryDto.Status = true;
            var value = _mapper.Map<Category>(createCategoryDto);
            _categoryManager.TAdd(value);
            return Ok("Kategori Eklendi");
        }


        [HttpGet("{id}")]

        public IActionResult GetCategory(int id)
        {
            var value = _categoryManager.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("CategoryCount")]

        public IActionResult GetCountCategory()
        {
            return Ok(_categoryManager.TCategoryCount());
        }
        [HttpGet("ActiveCategoryCount")]
        public IActionResult GetActiveCategoryCount()
        {
            return Ok(_categoryManager.TActiveCategoryCount());
        }
        [HttpGet("PassiveCategoryCount")]
        public IActionResult GetPassiveCategoryCount()
        {
            return Ok(_categoryManager.TPassiveCategoryCount());
        }

        [HttpPut] //**
        public IActionResult UpdateCategory(UpdateCategoryDto dto)
        {
            var value = _mapper.Map<Category>(dto);
            _categoryManager.TUpdate(value);
            return Ok("Güncellendi");
        }

        [HttpDelete("{id}")] // **

        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryManager.TGetByID(id);
            _categoryManager.TDelete(value);
            return Ok("Silindi");

        }
    }
}
