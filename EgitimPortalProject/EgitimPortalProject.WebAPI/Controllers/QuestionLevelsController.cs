using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionLevelsController : ControllerBase
    {
        private IQuestionLevelsService _questionlevelsService;

        public QuestionLevelsController(IQuestionLevelsService questionlevelsService)
        {
            _questionlevelsService = questionlevelsService;
        }

        [HttpGet("GetAll")]
        public List<QuestionLevels> GetAll()
        {
            return _questionlevelsService.GetAll();
        }

        [HttpGet("GetById")]
        public QuestionLevels GetById(int id)
        {
            return _questionlevelsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] QuestionLevels _questionlevelsFormData)
        {
            QuestionLevels _questionlevels = new QuestionLevels();

            _questionlevelsService.Add(_questionlevels);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] QuestionLevels _questionlevelsFormData)
        {
            QuestionLevels _questionlevels = new QuestionLevels();

            _questionlevelsService.Update(_questionlevels);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _questionlevelsService.Delete(_questionlevelsService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}