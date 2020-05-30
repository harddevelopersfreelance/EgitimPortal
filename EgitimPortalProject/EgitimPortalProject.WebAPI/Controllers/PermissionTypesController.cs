using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionTypesController : ControllerBase
    {
        private IPermissionTypesService _permissiontypesService;

        public PermissionTypesController(IPermissionTypesService permissiontypesService)
        {
            _permissiontypesService = permissiontypesService;
        }

        [HttpGet("GetAll")]
        public List<PermissionTypes> GetAll()
        {
            return _permissiontypesService.GetAll();
        }

        [HttpGet("GetById")]
        public PermissionTypes GetById(int id)
        {
            return _permissiontypesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] PermissionTypes _permissiontypesFormData)
        {
            PermissionTypes _permissiontypes = new PermissionTypes();

            _permissiontypesService.Add(_permissiontypes);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] PermissionTypes _permissiontypesFormData)
        {
            PermissionTypes _permissiontypes = new PermissionTypes();

            _permissiontypesService.Update(_permissiontypes);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _permissiontypesService.Delete(_permissiontypesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}