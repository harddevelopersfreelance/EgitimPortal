using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private IQuestionsService _questionsService;

        public QuestionsController(IQuestionsService questionsService)
        {
            _questionsService = questionsService;
        }

        [HttpGet("GetAll")]
        public List<Questions> GetAll()
        {
            return _questionsService.GetAll();
        }

        [HttpGet("GetById")]
        public Questions GetById(int id)
        {
            return _questionsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Questions _questionsFormData)
        {
            Questions _questions = new Questions();

            _questionsService.Add(_questions);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Questions _questionsFormData)
        {
            Questions _questions = new Questions();

            _questionsService.Update(_questions);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _questionsService.Delete(_questionsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByCatgoryId")] // Foreign key tablo servis   api/<controller>/GetListByQuestionsID/1
        public List<Questions> GetListByCatgoryId(int categoryid)
        {
            return _questionsService.GetListByCatgoryId(categoryid);
        }

        [HttpGet("GetListByQuestionLevelId")] // Foreign key tablo servis   api/<controller>/GetListByQuestionsID/1
        public List<Questions> GetListByQuestionLevelId(int questionlevelid)
        {
            return _questionsService.GetListByQuestionLevelId(questionlevelid);
        }

        [HttpGet("GetListByQuestionTypeId")] // Foreign key tablo servis   api/<controller>/GetListByQuestionsID/1
        public List<Questions> GetListByQuestionTypeId(int questiontypeid)
        {
            return _questionsService.GetListByQuestionTypeId(questiontypeid);
        }
    }
}