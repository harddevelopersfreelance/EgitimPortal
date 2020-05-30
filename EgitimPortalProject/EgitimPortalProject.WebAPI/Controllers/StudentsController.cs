using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentsService _studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpGet("GetAll")]
        public List<Students> GetAll()
        {
            return _studentsService.GetAll();
        }

        [HttpGet("GetById")]
        public Students GetById(int id)
        {
            return _studentsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Students _studentsFormData)
        {
            Students _students = new Students();

            _studentsService.Add(_students);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Students _studentsFormData)
        {
            Students _students = new Students();

            _studentsService.Update(_students);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _studentsService.Delete(_studentsService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}