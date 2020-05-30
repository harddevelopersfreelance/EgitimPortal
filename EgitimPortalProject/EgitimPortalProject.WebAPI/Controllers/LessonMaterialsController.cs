using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonMaterialsController : ControllerBase
    {
        private ILessonMaterialsService _lessonmaterialsService;

        public LessonMaterialsController(ILessonMaterialsService lessonmaterialsService)
        {
            _lessonmaterialsService = lessonmaterialsService;
        }

        [HttpGet("GetAll")]
        public List<LessonMaterials> GetAll()
        {
            return _lessonmaterialsService.GetAll();
        }

        [HttpGet("GetById")]
        public LessonMaterials GetById(int id)
        {
            return _lessonmaterialsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] LessonMaterials _lessonmaterialsFormData)
        {
            LessonMaterials _lessonmaterials = new LessonMaterials();

            _lessonmaterialsService.Add(_lessonmaterials);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] LessonMaterials _lessonmaterialsFormData)
        {
            LessonMaterials _lessonmaterials = new LessonMaterials();

            _lessonmaterialsService.Update(_lessonmaterials);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _lessonmaterialsService.Delete(_lessonmaterialsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByExamTypeId")] // Foreign key tablo servis   api/<controller>/GetListByLessonMaterialsID/1
        public List<LessonMaterials> GetListByExamTypeId(int typeid)
        {
            return _lessonmaterialsService.GetListByExamTypeId(typeid);
        }

        [HttpGet("GetListByLessonId")] // Foreign key tablo servis   api/<controller>/GetListByLessonMaterialsID/1
        public List<LessonMaterials> GetListByLessonId(int lessonid)
        {
            return _lessonmaterialsService.GetListByLessonId(lessonid);
        }
    }
}