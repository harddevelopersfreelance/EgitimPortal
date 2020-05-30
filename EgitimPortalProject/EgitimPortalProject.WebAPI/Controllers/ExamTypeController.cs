using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamTypeController : ControllerBase
    {
        private IExamTypeService _examtypeService;

        public ExamTypeController(IExamTypeService examtypeService)
        {
            _examtypeService = examtypeService;
        }

        [HttpGet("GetAll")]
        public List<ExamType> GetAll()
        {
            return _examtypeService.GetAll();
        }

        [HttpGet("GetById")]
        public ExamType GetById(int id)
        {
            return _examtypeService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] ExamType _examtypeFormData)
        {
            ExamType _examtype = new ExamType();

            _examtypeService.Add(_examtype);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] ExamType _examtypeFormData)
        {
            ExamType _examtype = new ExamType();

            _examtypeService.Update(_examtype);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _examtypeService.Delete(_examtypeService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}