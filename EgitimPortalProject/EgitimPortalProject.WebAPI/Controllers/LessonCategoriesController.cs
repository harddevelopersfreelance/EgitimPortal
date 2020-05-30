using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonCategoriesController : ControllerBase
    {
        private ILessonCategoriesService _lessoncategoriesService;

        public LessonCategoriesController(ILessonCategoriesService lessoncategoriesService)
        {
            _lessoncategoriesService = lessoncategoriesService;
        }

        [HttpGet("GetAll")]
        public List<LessonCategories> GetAll()
        {
            return _lessoncategoriesService.GetAll();
        }

        [HttpGet("GetById")]
        public LessonCategories GetById(int id)
        {
            return _lessoncategoriesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] LessonCategories _lessoncategoriesFormData)
        {
            LessonCategories _lessoncategories = new LessonCategories();

            _lessoncategoriesService.Add(_lessoncategories);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] LessonCategories _lessoncategoriesFormData)
        {
            LessonCategories _lessoncategories = new LessonCategories();

            _lessoncategoriesService.Update(_lessoncategories);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _lessoncategoriesService.Delete(_lessoncategoriesService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByLessonId")] // Foreign key tablo servis   api/<controller>/GetListByLessonCategoriesID/1
        public List<LessonCategories> GetListByLessonId(int lessonid)
        {
            return _lessoncategoriesService.GetListByLessonId(lessonid);
        }

        [HttpGet("GetListByCategoryId")] // Foreign key tablo servis   api/<controller>/GetListByLessonCategoriesID/1
        public List<LessonCategories> GetListByCategoryId(int categoryid)
        {
            return _lessoncategoriesService.GetListByCategoryId(categoryid);
        }
    }
}