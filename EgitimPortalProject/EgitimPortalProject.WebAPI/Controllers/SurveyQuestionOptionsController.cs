using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyQuestionOptionsController : ControllerBase
    {
        private ISurveyQuestionOptionsService _surveyquestionoptionsService;

        public SurveyQuestionOptionsController(ISurveyQuestionOptionsService surveyquestionoptionsService)
        {
            _surveyquestionoptionsService = surveyquestionoptionsService;
        }

        [HttpGet("GetAll")]
        public List<SurveyQuestionOptions> GetAll()
        {
            return _surveyquestionoptionsService.GetAll();
        }

        [HttpGet("GetById")]
        public SurveyQuestionOptions GetById(int id)
        {
            return _surveyquestionoptionsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] SurveyQuestionOptions _surveyquestionoptionsFormData)
        {
            SurveyQuestionOptions _surveyquestionoptions = new SurveyQuestionOptions();

            _surveyquestionoptionsService.Add(_surveyquestionoptions);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] SurveyQuestionOptions _surveyquestionoptionsFormData)
        {
            SurveyQuestionOptions _surveyquestionoptions = new SurveyQuestionOptions();

            _surveyquestionoptionsService.Update(_surveyquestionoptions);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _surveyquestionoptionsService.Delete(_surveyquestionoptionsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByQuestionOptionTypeId")] // Foreign key tablo servis   api/<controller>/GetListBySurveyQuestionOptionsID/1
        public List<SurveyQuestionOptions> GetListByQuestionOptionTypeId(int questionoptiontypeid)
        {
            return _surveyquestionoptionsService.GetListByQuestionOptionTypeId(questionoptiontypeid);
        }
    }
}