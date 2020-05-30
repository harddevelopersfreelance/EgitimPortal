using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private IExamsService _examsService;

        public ExamsController(IExamsService examsService)
        {
            _examsService = examsService;
        }

        [HttpGet("GetAll")]
        public List<Exams> GetAll()
        {
            return _examsService.GetAll();
        }

        [HttpGet("GetById")]
        public Exams GetById(int id)
        {
            return _examsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Exams _examsFormData)
        {
            Exams _exams = new Exams();

            _examsService.Add(_exams);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Exams _examsFormData)
        {
            Exams _exams = new Exams();

            _examsService.Update(_exams);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _examsService.Delete(_examsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByExamTypeId")] // Foreign key tablo servis   api/<controller>/GetListByExamsID/1
        public List<Exams> GetListByExamTypeId(int examtypeid)
        {
            return _examsService.GetListByExamTypeId(examtypeid);
        }
    }
}