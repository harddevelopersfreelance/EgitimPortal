using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialTypesController : ControllerBase
    {
        private IMaterialTypesService _materialtypesService;

        public MaterialTypesController(IMaterialTypesService materialtypesService)
        {
            _materialtypesService = materialtypesService;
        }

        [HttpGet("GetAll")]
        public List<MaterialTypes> GetAll()
        {
            return _materialtypesService.GetAll();
        }

        [HttpGet("GetById")]
        public MaterialTypes GetById(int id)
        {
            return _materialtypesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] MaterialTypes _materialtypesFormData)
        {
            MaterialTypes _materialtypes = new MaterialTypes();

            _materialtypesService.Add(_materialtypes);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] MaterialTypes _materialtypesFormData)
        {
            MaterialTypes _materialtypes = new MaterialTypes();

            _materialtypesService.Update(_materialtypes);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _materialtypesService.Delete(_materialtypesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}