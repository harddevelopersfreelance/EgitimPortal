using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionAnswersController : ControllerBase
    {
        private IQuestionAnswersService _questionanswersService;

        public QuestionAnswersController(IQuestionAnswersService questionanswersService)
        {
            _questionanswersService = questionanswersService;
        }

        [HttpGet("GetAll")]
        public List<QuestionAnswers> GetAll()
        {
            return _questionanswersService.GetAll();
        }

        [HttpGet("GetById")]
        public QuestionAnswers GetById(int id)
        {
            return _questionanswersService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] QuestionAnswers _questionanswersFormData)
        {
            QuestionAnswers _questionanswers = new QuestionAnswers();

            _questionanswersService.Add(_questionanswers);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] QuestionAnswers _questionanswersFormData)
        {
            QuestionAnswers _questionanswers = new QuestionAnswers();

            _questionanswersService.Update(_questionanswers);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _questionanswersService.Delete(_questionanswersService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByQuestionId")] // Foreign key tablo servis   api/<controller>/GetListByQuestionAnswersID/1
        public List<QuestionAnswers> GetListByQuestionId(int questionid)
        {
            return _questionanswersService.GetListByQuestionId(questionid);
        }

        [HttpGet("GetListByOptionId")] // Foreign key tablo servis   api/<controller>/GetListByQuestionAnswersID/1
        public List<QuestionAnswers> GetListByOptionId(int optionid)
        {
            return _questionanswersService.GetListByOptionId(optionid);
        }
    }
}