using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private ILessonsService _lessonsService;

        public LessonsController(ILessonsService lessonsService)
        {
            _lessonsService = lessonsService;
        }

        [HttpGet("GetAll")]
        public List<Lessons> GetAll()
        {
            return _lessonsService.GetAll();
        }

        [HttpGet("GetById")]
        public Lessons GetById(int id)
        {
            return _lessonsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Lessons _lessonsFormData)
        {
            Lessons _lessons = new Lessons();

            _lessonsService.Add(_lessons);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Lessons _lessonsFormData)
        {
            Lessons _lessons = new Lessons();

            _lessonsService.Update(_lessons);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _lessonsService.Delete(_lessonsService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}