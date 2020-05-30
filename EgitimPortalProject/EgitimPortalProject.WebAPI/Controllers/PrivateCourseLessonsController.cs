using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrivateCourseLessonsController : ControllerBase
    {
        private IPrivateCourseLessonsService _privatecourselessonsService;

        public PrivateCourseLessonsController(IPrivateCourseLessonsService privatecourselessonsService)
        {
            _privatecourselessonsService = privatecourselessonsService;
        }

        [HttpGet("GetAll")]
        public List<PrivateCourseLessons> GetAll()
        {
            return _privatecourselessonsService.GetAll();
        }

        [HttpGet("GetById")]
        public PrivateCourseLessons GetById(int id)
        {
            return _privatecourselessonsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] PrivateCourseLessons _privatecourselessonsFormData)
        {
            PrivateCourseLessons _privatecourselessons = new PrivateCourseLessons();

            _privatecourselessonsService.Add(_privatecourselessons);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] PrivateCourseLessons _privatecourselessonsFormData)
        {
            PrivateCourseLessons _privatecourselessons = new PrivateCourseLessons();
            _privatecourselessonsService.Update(_privatecourselessonsFormData);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _privatecourselessonsService.Delete(_privatecourselessonsService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}