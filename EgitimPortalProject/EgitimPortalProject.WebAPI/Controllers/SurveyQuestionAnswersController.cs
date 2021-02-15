using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyQuestionAnswersController : ControllerBase
    {
        private ISurveyQuestionAnswersService _surveyquestionanswersService;

        public SurveyQuestionAnswersController(ISurveyQuestionAnswersService surveyquestionanswersService)
        {
            _surveyquestionanswersService = surveyquestionanswersService;
        }

        [HttpGet("GetAll")]
        public List<SurveyQuestionAnswers> GetAll()
        {
            return _surveyquestionanswersService.GetAll();
        }

        [HttpGet("GetById")]
        public SurveyQuestionAnswers GetById(int id)
        {
            return _surveyquestionanswersService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] SurveyQuestionAnswers _surveyquestionanswersFormData)
        {
            SurveyQuestionAnswers _surveyquestionanswers = new SurveyQuestionAnswers();

            _surveyquestionanswersService.Add(_surveyquestionanswers);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] SurveyQuestionAnswers _surveyquestionanswersFormData)
        {
            SurveyQuestionAnswers _surveyquestionanswers = new SurveyQuestionAnswers();

            _surveyquestionanswersService.Update(_surveyquestionanswers);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _surveyquestionanswersService.Delete(_surveyquestionanswersService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByQuestionId")] // Foreign key tablo servis   api/<controller>/GetListBySurveyQuestionAnswersID/1
        public List<SurveyQuestionAnswers> GetListByQuestionId(int questionid)
        {
            return _surveyquestionanswersService.GetListByQuestionId(questionid);
        }

        [HttpGet("GetListByOptionId")] // Foreign key tablo servis   api/<controller>/GetListBySurveyQuestionAnswersID/1
        public List<SurveyQuestionAnswers> GetListByOptionId(int optionid)
        {
            return _surveyquestionanswersService.GetListByOptionId(optionid);
        }
    }
}