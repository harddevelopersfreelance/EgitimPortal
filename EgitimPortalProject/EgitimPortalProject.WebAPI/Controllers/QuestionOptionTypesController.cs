using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionOptionTypesController : ControllerBase
    {
        private IQuestionOptionTypesService _questionoptiontypesService;

        public QuestionOptionTypesController(IQuestionOptionTypesService questionoptiontypesService)
        {
            _questionoptiontypesService = questionoptiontypesService;
        }

        [HttpGet("GetAll")]
        public List<QuestionOptionTypes> GetAll()
        {
            return _questionoptiontypesService.GetAll();
        }

        [HttpGet("GetById")]
        public QuestionOptionTypes GetById(int id)
        {
            return _questionoptiontypesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] QuestionOptionTypes _questionoptiontypesFormData)
        {
            QuestionOptionTypes _questionoptiontypes = new QuestionOptionTypes();

            _questionoptiontypesService.Add(_questionoptiontypes);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] QuestionOptionTypes _questionoptiontypesFormData)
        {
            QuestionOptionTypes _questionoptiontypes = new QuestionOptionTypes();

            _questionoptiontypesService.Update(_questionoptiontypes);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _questionoptiontypesService.Delete(_questionoptiontypesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}