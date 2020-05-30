using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCoursesController : ControllerBase
    {
        private IStudentCoursesService _studentcoursesService;

        public StudentCoursesController(IStudentCoursesService studentcoursesService)
        {
            _studentcoursesService = studentcoursesService;
        }

        [HttpGet("GetAll")]
        public List<StudentCourses> GetAll()
        {
            return _studentcoursesService.GetAll();
        }

        [HttpGet("GetById")]
        public StudentCourses GetById(int id)
        {
            return _studentcoursesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] StudentCourses _studentcoursesFormData)
        {
            StudentCourses _studentcourses = new StudentCourses();

            _studentcoursesService.Add(_studentcourses);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] StudentCourses _studentcoursesFormData)
        {
            StudentCourses _studentcourses = new StudentCourses();

            _studentcoursesService.Update(_studentcourses);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _studentcoursesService.Delete(_studentcoursesService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByStudentsId")] // Foreign key tablo servis   api/<controller>/GetListByStudentCoursesID/1
        public List<StudentCourses> GetListByStudentsId(int studentid)
        {
            return _studentcoursesService.GetListByStudentsId(studentid);
        }

        [HttpGet("GetListByCoursesId")] // Foreign key tablo servis   api/<controller>/GetListByStudentCoursesID/1
        public List<StudentCourses> GetListByCoursesId(int courseid)
        {
            return _studentcoursesService.GetListByCoursesId(courseid);
        }
    }
}