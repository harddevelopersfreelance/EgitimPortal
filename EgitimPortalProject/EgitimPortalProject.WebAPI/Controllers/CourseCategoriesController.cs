using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController : ControllerBase
    {
        private ICourseCategoriesService _coursecategoriesService;

        public CourseCategoriesController(ICourseCategoriesService coursecategoriesService)
        {
            _coursecategoriesService = coursecategoriesService;
        }

        [HttpGet("GetAll")]
        public List<CourseCategories> GetAll()
        {
            return _coursecategoriesService.GetAll();
        }

        [HttpGet("GetById")]
        public CourseCategories GetById(int id)
        {
            return _coursecategoriesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] CourseCategories _coursecategoriesFormData)
        {
            CourseCategories _coursecategories = new CourseCategories();

            _coursecategoriesService.Add(_coursecategories);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] CourseCategories _coursecategoriesFormData)
        {
            CourseCategories _coursecategories = new CourseCategories();

            _coursecategoriesService.Update(_coursecategories);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _coursecategoriesService.Delete(_coursecategoriesService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByCoursesId")]
        public List<CourseCategories> GetListByCoursesId(int courseid)
        {
            return _coursecategoriesService.GetListByCoursesId(courseid);
        }

        [HttpGet("GetListByCategoriesId")]
        public List<CourseCategories> GetListByCategoriesId(int flagid)
        {
            return _coursecategoriesService.GetListByCategoriesId(flagid);
        }
    }
}