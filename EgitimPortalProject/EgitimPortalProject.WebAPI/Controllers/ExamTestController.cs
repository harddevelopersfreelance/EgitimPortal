using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamTestController : ControllerBase
    {
        private IExamTestService _examtestService;

        public ExamTestController(IExamTestService examtestService)
        {
            _examtestService = examtestService;
        }

        [HttpGet("GetAll")]
        public List<ExamTest> GetAll()
        {
            return _examtestService.GetAll();
        }

        [HttpGet("GetById")]
        public ExamTest GetById(int id)
        {
            return _examtestService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] ExamTest _examtestFormData)
        {
            ExamTest _examtest = new ExamTest();

            _examtestService.Add(_examtest);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] ExamTest _examtestFormData)
        {
            ExamTest _examtest = new ExamTest();

            _examtestService.Update(_examtest);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _examtestService.Delete(_examtestService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}