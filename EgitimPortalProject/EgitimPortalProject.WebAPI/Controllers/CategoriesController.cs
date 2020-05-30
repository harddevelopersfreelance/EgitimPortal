using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet("GetAll")]
        public List<Categories> GetAll()
        {
            return _categoriesService.GetAll();
        }

        [HttpGet("GetById")]
        public Categories GetById(int id)
        {
            return _categoriesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Categories _categoriesFormData)
        {
            Categories _categories = new Categories();
            //
            _categoriesService.Add(_categories);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Categories _categoriesFormData)
        {
            Categories _categories = new Categories();
            //
            _categoriesService.Update(_categories);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _categoriesService.Delete(_categoriesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}