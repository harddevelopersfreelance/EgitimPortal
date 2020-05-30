using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherCourseLessonsController : ControllerBase
    {
        private ITeacherCourseLessonsService _teachercourselessonsService;

        public TeacherCourseLessonsController(ITeacherCourseLessonsService teachercourselessonsService)
        {
            _teachercourselessonsService = teachercourselessonsService;
        }

        [HttpGet("GetAll")]
        public List<TeacherCourseLessons> GetAll()
        {
            return _teachercourselessonsService.GetAll();
        }

        [HttpGet("GetById")]
        public TeacherCourseLessons GetById(int id)
        {
            return _teachercourselessonsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] TeacherCourseLessons _teachercourselessonsFormData)
        {
            TeacherCourseLessons _teachercourselessons = new TeacherCourseLessons();

            _teachercourselessonsService.Add(_teachercourselessons);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] TeacherCourseLessons _teachercourselessonsFormData)
        {
            TeacherCourseLessons _teachercourselessons = new TeacherCourseLessons();

            _teachercourselessonsService.Update(_teachercourselessons);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _teachercourselessonsService.Delete(_teachercourselessonsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByCoursesId")] // Foreign key tablo servis   api/<controller>/GetListByTeacherCourseLessonsID/1
        public List<TeacherCourseLessons> GetListByCoursesId(int courseid)
        {
            return _teachercourselessonsService.GetListByCoursesId(courseid);
        }

        [HttpGet("GetListByLessonId")] // Foreign key tablo servis   api/<controller>/GetListByTeacherCourseLessonsID/1
        public List<TeacherCourseLessons> GetListByLessonId(int lessonid)
        {
            return _teachercourselessonsService.GetListByLessonId(lessonid);
        }
    }
}