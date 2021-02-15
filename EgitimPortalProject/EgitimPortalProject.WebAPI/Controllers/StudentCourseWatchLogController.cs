using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseWatchLogController : ControllerBase
    {
        private IStudentCourseWatchLogService _studentcoursewatchlogService;

        public StudentCourseWatchLogController(IStudentCourseWatchLogService studentcoursewatchlogService)
        {
            _studentcoursewatchlogService = studentcoursewatchlogService;
        }

        [HttpGet("GetAll")]
        public List<StudentCourseWatchLog> GetAll()
        {
            return _studentcoursewatchlogService.GetAll();
        }

        [HttpGet("GetById")]
        public StudentCourseWatchLog GetById(int id)
        {
            return _studentcoursewatchlogService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] StudentCourseWatchLog _studentcoursewatchlogFormData)
        {
            StudentCourseWatchLog _studentcoursewatchlog = new StudentCourseWatchLog();
            //
            _studentcoursewatchlogService.Add(_studentcoursewatchlog);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] StudentCourseWatchLog _studentcoursewatchlogFormData)
        {
            StudentCourseWatchLog _studentcoursewatchlog = new StudentCourseWatchLog();
            ///
            _studentcoursewatchlogService.Update(_studentcoursewatchlog);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _studentcoursewatchlogService.Delete(_studentcoursewatchlogService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}