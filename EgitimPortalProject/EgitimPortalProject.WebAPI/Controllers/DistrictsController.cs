using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private IDistrictsService _districtsService;

        public DistrictsController(IDistrictsService districtsService)
        {
            _districtsService = districtsService;
        }

        [HttpGet("GetAll")]
        public List<Districts> GetAll()
        {
            return _districtsService.GetAll();
        }

        [HttpGet("GetById")]
        public Districts GetById(int id)
        {
            return _districtsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Districts _districtsFormData)
        {
            Districts _districts = new Districts();

            _districtsService.Add(_districts);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Districts _districtsFormData)
        {
            Districts _districts = new Districts();

            _districtsService.Update(_districts);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _districtsService.Delete(_districtsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByCityId")] // Foreign key tablo servis   api/<controller>/GetListByDistrictsID/1
        public List<Districts> GetListByCityId(int cityid)
        {
            return _districtsService.GetListByCityId(cityid);
        }
    }
}