using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseTeachersController : ControllerBase
    {
        private ICourseTeachersService _courseteachersService;

        public CourseTeachersController(ICourseTeachersService courseteachersService)
        {
            _courseteachersService = courseteachersService;
        }

        [HttpGet("GetAll")]
        public List<CourseTeachers> GetAll()
        {
            return _courseteachersService.GetAll();
        }

        [HttpGet("GetById")]
        public CourseTeachers GetById(int id)
        {
            return _courseteachersService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] CourseTeachers _courseteachersFormData)
        {
            _courseteachersService.Add(_courseteachersFormData);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] CourseTeachers _courseteachersFormData)
        {
            CourseTeachers _courseteachers = new CourseTeachers();

            _courseteachersService.Update(_courseteachersFormData);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _courseteachersService.Delete(_courseteachersService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByTeachersId")] // Foreign key tablo servis   api/<controller>/GetListByCourseTeachersID/1
        public List<CourseTeachers> GetListByTeachersId(int teacherid)
        {
            return _courseteachersService.GetListByTeachersId(teacherid);
        }

        [HttpGet("GetListByCoursesId")] // Foreign key tablo servis   api/<controller>/GetListByCourseTeachersID/1
        public List<CourseTeachers> GetListByCoursesId(int courseid)
        {
            return _courseteachersService.GetListByCoursesId(courseid);
        }
    }
}