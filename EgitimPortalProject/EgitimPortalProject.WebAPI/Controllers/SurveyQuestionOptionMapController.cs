using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyQuestionOptionMapController : ControllerBase
    {
        private ISurveyQuestionOptionMapService _surveyquestionoptionmapService;

        public SurveyQuestionOptionMapController(ISurveyQuestionOptionMapService surveyquestionoptionmapService)
        {
            _surveyquestionoptionmapService = surveyquestionoptionmapService;
        }

        [HttpGet("GetAll")]
        public List<SurveyQuestionOptionMap> GetAll()
        {
            return _surveyquestionoptionmapService.GetAll();
        }

        [HttpGet("GetById")]
        public SurveyQuestionOptionMap GetById(int id)
        {
            return _surveyquestionoptionmapService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] SurveyQuestionOptionMap _surveyquestionoptionmapFormData)
        {
            SurveyQuestionOptionMap _surveyquestionoptionmap = new SurveyQuestionOptionMap();

            _surveyquestionoptionmapService.Add(_surveyquestionoptionmap);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] SurveyQuestionOptionMap _surveyquestionoptionmapFormData)
        {
            SurveyQuestionOptionMap _surveyquestionoptionmap = new SurveyQuestionOptionMap();

            _surveyquestionoptionmapService.Update(_surveyquestionoptionmap);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _surveyquestionoptionmapService.Delete(_surveyquestionoptionmapService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListBySurveyQuestionId")] // Foreign key tablo servis   api/<controller>/GetListBySurveyQuestionOptionMapID/1
        public List<SurveyQuestionOptionMap> GetListBySurveyQuestionId(int surveyquestionid)
        {
            return _surveyquestionoptionmapService.GetListBySurveyQuestionId(surveyquestionid);
        }

        [HttpGet("GetListBySurveyOptionId")] // Foreign key tablo servis   api/<controller>/GetListBySurveyQuestionOptionMapID/1
        public List<SurveyQuestionOptionMap> GetListBySurveyOptionId(int surveyoptionid)
        {
            return _surveyquestionoptionmapService.GetListBySurveyOptionId(surveyoptionid);
        }
    }
}