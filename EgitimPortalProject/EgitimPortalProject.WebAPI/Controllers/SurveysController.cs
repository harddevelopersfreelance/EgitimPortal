using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        private ISurveysService _surveysService;

        public SurveysController(ISurveysService surveysService)
        {
            _surveysService = surveysService;
        }

        [HttpGet("GetAll")]
        public List<Surveys> GetAll()
        {
            return _surveysService.GetAll();
        }

        [HttpGet("GetById")]
        public Surveys GetById(int id)
        {
            return _surveysService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Surveys _surveysFormData)
        {
            Surveys _surveys = new Surveys();

            _surveysService.Add(_surveys);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Surveys _surveysFormData)
        {
            Surveys _surveys = new Surveys();

            _surveysService.Update(_surveys);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _surveysService.Delete(_surveysService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByUserRolesId")] // Foreign key tablo servis   api/<controller>/GetListBySurveysID/1
        public List<Surveys> GetListByUserRolesId(int id)
        {
            return _surveysService.GetListByUserRolesId(id);
        }
    }
}