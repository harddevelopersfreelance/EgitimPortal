using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionOptionsController : ControllerBase
    {
        private IQuestionOptionsService _questionoptionsService;

        public QuestionOptionsController(IQuestionOptionsService questionoptionsService)
        {
            _questionoptionsService = questionoptionsService;
        }

        [HttpGet("GetAll")]
        public List<QuestionOptions> GetAll()
        {
            return _questionoptionsService.GetAll();
        }

        [HttpGet("GetById")]
        public QuestionOptions GetById(int id)
        {
            return _questionoptionsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] QuestionOptions _questionoptionsFormData)
        {
            QuestionOptions _questionoptions = new QuestionOptions();

            _questionoptionsService.Add(_questionoptions);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] QuestionOptions _questionoptionsFormData)
        {
            QuestionOptions _questionoptions = new QuestionOptions();

            _questionoptionsService.Update(_questionoptions);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _questionoptionsService.Delete(_questionoptionsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByQuestionOptionTypeId")] // Foreign key tablo servis   api/<controller>/GetListByQuestionOptionsID/1
        public List<QuestionOptions> GetListByQuestionOptionTypeId(int questionoptiontypeid)
        {
            return _questionoptionsService.GetListByQuestionOptionTypeId(questionoptiontypeid);
        }
    }
}