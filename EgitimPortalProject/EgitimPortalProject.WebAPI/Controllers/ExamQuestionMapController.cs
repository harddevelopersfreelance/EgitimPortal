using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamQuestionMapController : ControllerBase
    {
        private IExamQuestionMapService _examquestionmapService;

        public ExamQuestionMapController(IExamQuestionMapService examquestionmapService)
        {
            _examquestionmapService = examquestionmapService;
        }

        [HttpGet("GetAll")]
        public List<ExamQuestionMap> GetAll()
        {
            return _examquestionmapService.GetAll();
        }

        [HttpGet("GetById")]
        public ExamQuestionMap GetById(int id)
        {
            return _examquestionmapService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] ExamQuestionMap _examquestionmapFormData)
        {
            ExamQuestionMap _examquestionmap = new ExamQuestionMap();

            _examquestionmapService.Add(_examquestionmap);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] ExamQuestionMap _examquestionmapFormData)
        {
            ExamQuestionMap _examquestionmap = new ExamQuestionMap();

            _examquestionmapService.Update(_examquestionmap);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _examquestionmapService.Delete(_examquestionmapService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByExamId")] // Foreign key tablo servis   api/<controller>/GetListByExamQuestionMapID/1
        public List<ExamQuestionMap> GetListByExamId(int examid)
        {
            return _examquestionmapService.GetListByExamId(examid);
        }

        [HttpGet("GetListByQuestionId")] // Foreign key tablo servis   api/<controller>/GetListByExamQuestionMapID/1
        public List<ExamQuestionMap> GetListByQuestionId(int questionid)
        {
            return _examquestionmapService.GetListByQuestionId(questionid);
        }
    }
}