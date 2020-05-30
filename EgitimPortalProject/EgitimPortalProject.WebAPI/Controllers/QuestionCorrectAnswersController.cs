using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionCorrectAnswersController : ControllerBase
    {
        private IQuestionCorrectAnswersService _questioncorrectanswersService;

        public QuestionCorrectAnswersController(IQuestionCorrectAnswersService questioncorrectanswersService)
        {
            _questioncorrectanswersService = questioncorrectanswersService;
        }

        [HttpGet("GetAll")]
        public List<QuestionCorrectAnswers> GetAll()
        {
            return _questioncorrectanswersService.GetAll();
        }

        [HttpGet("GetById")]
        public QuestionCorrectAnswers GetById(int id)
        {
            return _questioncorrectanswersService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] QuestionCorrectAnswers _questioncorrectanswersFormData)
        {
            QuestionCorrectAnswers _questioncorrectanswers = new QuestionCorrectAnswers();

            _questioncorrectanswersService.Add(_questioncorrectanswers);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] QuestionCorrectAnswers _questioncorrectanswersFormData)
        {
            QuestionCorrectAnswers _questioncorrectanswers = new QuestionCorrectAnswers();

            _questioncorrectanswersService.Update(_questioncorrectanswers);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _questioncorrectanswersService.Delete(_questioncorrectanswersService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}