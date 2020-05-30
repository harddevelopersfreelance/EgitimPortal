using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionOptionsMapController : ControllerBase
    {
        private IQuestionOptionsMapService _questionoptionsmapService;

        public QuestionOptionsMapController(IQuestionOptionsMapService questionoptionsmapService)
        {
            _questionoptionsmapService = questionoptionsmapService;
        }

        [HttpGet("GetAll")]
        public List<QuestionOptionsMap> GetAll()
        {
            return _questionoptionsmapService.GetAll();
        }

        [HttpGet("GetById")]
        public QuestionOptionsMap GetById(int id)
        {
            return _questionoptionsmapService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] QuestionOptionsMap _questionoptionsmapFormData)
        {
            QuestionOptionsMap _questionoptionsmap = new QuestionOptionsMap();

            _questionoptionsmapService.Add(_questionoptionsmap);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] QuestionOptionsMap _questionoptionsmapFormData)
        {
            QuestionOptionsMap _questionoptionsmap = new QuestionOptionsMap();

            _questionoptionsmapService.Update(_questionoptionsmap);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _questionoptionsmapService.Delete(_questionoptionsmapService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByQuestionId")] // Foreign key tablo servis   api/<controller>/GetListByQuestionOptionsMapID/1
        public List<QuestionOptionsMap> GetListByQuestionId(int questionid)
        {
            return _questionoptionsmapService.GetListByQuestionId(questionid);
        }

        [HttpGet("GetListByOptionId")] // Foreign key tablo servis   api/<controller>/GetListByQuestionOptionsMapID/1
        public List<QuestionOptionsMap> GetListByOptionId(int optionid)
        {
            return _questionoptionsmapService.GetListByOptionId(optionid);
        }
    }
}