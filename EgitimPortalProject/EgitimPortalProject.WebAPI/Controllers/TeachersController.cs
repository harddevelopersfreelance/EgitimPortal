using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private ITeachersService _teachersService;

        public TeachersController(ITeachersService teachersService)
        {
            _teachersService = teachersService;
        }

        [HttpGet("GetAll")]
        public List<Teachers> GetAll()
        {
            return _teachersService.GetAll();
        }

        [HttpGet("GetById")]
        public Teachers GetById(int id)
        {
            return _teachersService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Teachers _teachersFormData)
        {
            Teachers _teachers = new Teachers();

            _teachersService.Add(_teachers);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Teachers _teachersFormData)
        {
            Teachers _teachers = new Teachers();

            _teachersService.Update(_teachers);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _teachersService.Delete(_teachersService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}