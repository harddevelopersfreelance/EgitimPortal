using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private IGenderService _genderService;

        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }

        [HttpGet("GetAll")]
        public List<Gender> GetAll()
        {
            return _genderService.GetAll();
        }

        [HttpGet("GetById")]
        public Gender GetById(int id)
        {
            return _genderService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Gender _genderFormData)
        {
            Gender _gender = new Gender();

            _genderService.Add(_gender);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Gender _genderFormData)
        {
            Gender _gender = new Gender();

            _genderService.Update(_gender);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _genderService.Delete(_genderService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}