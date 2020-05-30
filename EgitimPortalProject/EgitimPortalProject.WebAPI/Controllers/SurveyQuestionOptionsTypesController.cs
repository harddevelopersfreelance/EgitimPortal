using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyQuestionOptionsTypesController : ControllerBase
    {
        private ISurveyQuestionOptionsTypesService _surveyquestionoptionstypesService;

        public SurveyQuestionOptionsTypesController(ISurveyQuestionOptionsTypesService surveyquestionoptionstypesService)
        {
            _surveyquestionoptionstypesService = surveyquestionoptionstypesService;
        }

        [HttpGet("GetAll")]
        public List<SurveyQuestionOptionsTypes> GetAll()
        {
            return _surveyquestionoptionstypesService.GetAll();
        }

        [HttpGet("GetById")]
        public SurveyQuestionOptionsTypes GetById(int id)
        {
            return _surveyquestionoptionstypesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] SurveyQuestionOptionsTypes _surveyquestionoptionstypesFormData)
        {
            SurveyQuestionOptionsTypes _surveyquestionoptionstypes = new SurveyQuestionOptionsTypes();

            _surveyquestionoptionstypesService.Add(_surveyquestionoptionstypes);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] SurveyQuestionOptionsTypes _surveyquestionoptionstypesFormData)
        {
            SurveyQuestionOptionsTypes _surveyquestionoptionstypes = new SurveyQuestionOptionsTypes();

            _surveyquestionoptionstypesService.Update(_surveyquestionoptionstypes);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _surveyquestionoptionstypesService.Delete(_surveyquestionoptionstypesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}