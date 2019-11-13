using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PracticeApi.Context;
using PracticeApi.Models;
using PracticeApi.Service;
using PracticeApi.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApi.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);

            // #For Refernce if we do nt use automapper !!
          
            //List<Category> categoriesd = new List<Category>();
            //foreach (var item in categoriesd)
            //{
            //    Category category = new Category
            //    {
            //        Name = item.Name
            //    };

            //    categoriesd.Add(category);

            //}
            return resource;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CategoryResource resource)
        {
            return Ok();
        }
    }
}