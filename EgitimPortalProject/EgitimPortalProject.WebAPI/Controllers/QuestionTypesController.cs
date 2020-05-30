using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionTypesController : ControllerBase
    {
        private IQuestionTypesService _questiontypesService;

        public QuestionTypesController(IQuestionTypesService questiontypesService)
        {
            _questiontypesService = questiontypesService;
        }

        [HttpGet("GetAll")]
        public List<QuestionTypes> GetAll()
        {
            return _questiontypesService.GetAll();
        }

        [HttpGet("GetById")]
        public QuestionTypes GetById(int id)
        {
            return _questiontypesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] QuestionTypes _questiontypesFormData)
        {
            QuestionTypes _questiontypes = new QuestionTypes();

            _questiontypesService.Add(_questiontypes);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] QuestionTypes _questiontypesFormData)
        {
            QuestionTypes _questiontypes = new QuestionTypes();

            _questiontypesService.Update(_questiontypes);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _questiontypesService.Delete(_questiontypesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}