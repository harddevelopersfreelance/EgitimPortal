using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyQuestionsController : ControllerBase
    {
        private ISurveyQuestionsService _surveyquestionsService;

        public SurveyQuestionsController(ISurveyQuestionsService surveyquestionsService)
        {
            _surveyquestionsService = surveyquestionsService;
        }

        [HttpGet("GetAll")]
        public List<SurveyQuestions> GetAll()
        {
            return _surveyquestionsService.GetAll();
        }

        [HttpGet("GetById")]
        public SurveyQuestions GetById(int id)
        {
            return _surveyquestionsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] SurveyQuestions _surveyquestionsFormData)
        {
            SurveyQuestions _surveyquestions = new SurveyQuestions();

            _surveyquestionsService.Add(_surveyquestions);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] SurveyQuestions _surveyquestionsFormData)
        {
            SurveyQuestions _surveyquestions = new SurveyQuestions();

            _surveyquestionsService.Update(_surveyquestions);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _surveyquestionsService.Delete(_surveyquestionsService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}