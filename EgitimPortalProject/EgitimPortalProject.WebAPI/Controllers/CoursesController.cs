using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICoursesService _coursesService;

        public CoursesController(ICoursesService coursesService)
        {
            _coursesService = coursesService;
        }

        [HttpGet("GetAll")]
        public List<Courses> GetAll()
        {
            return _coursesService.GetAll();
        }

        [HttpGet("GetById")]
        public Courses GetById(int id)
        {
            return _coursesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Courses _coursesFormData)
        {
            Courses _courses = new Courses();

            _coursesService.Add(_courses);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Courses _coursesFormData)
        {
            Courses _courses = new Courses();

            _coursesService.Update(_courses);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _coursesService.Delete(_coursesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}