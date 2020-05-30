using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ICitiesService _citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
        }

        [HttpGet("GetAll")]
        public List<Cities> GetAll()
        {
            return _citiesService.GetAll();
        }

        [HttpGet("GetById")]
        public Cities GetById(int id)
        {
            return _citiesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Cities _citiesFormData)
        {
            Cities _cities = new Cities();

            _citiesService.Add(_cities);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Cities _citiesFormData)
        {
            Cities _cities = new Cities();

            _citiesService.Update(_cities);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _citiesService.Delete(_citiesService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByCauntryId")] // Foreign key tablo servis   api/<controller>/GetListByCitiesID/1
        public List<Cities> GetListByCauntryId(int cauntryid)
        {
            return _citiesService.GetListByCauntryId(cauntryid);
        }
    }
}