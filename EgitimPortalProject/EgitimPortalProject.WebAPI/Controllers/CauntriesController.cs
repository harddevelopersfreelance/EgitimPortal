using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CauntriesController : ControllerBase
    {
        private ICauntriesService _cauntriesService;

        public CauntriesController(ICauntriesService cauntriesService)
        {
            _cauntriesService = cauntriesService;
        }

        [HttpGet("GetAll")]
        public List<Cauntries> GetAll()
        {
            return _cauntriesService.GetAll();
        }

        [HttpGet("GetById")]
        public Cauntries GetById(int id)
        {
            return _cauntriesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Cauntries _cauntriesFormData)
        {
            Cauntries _cauntries = new Cauntries();

            _cauntriesService.Add(_cauntries);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Cauntries _cauntriesFormData)
        {
            Cauntries _cauntries = new Cauntries();

            _cauntriesService.Update(_cauntries);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _cauntriesService.Delete(_cauntriesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}