using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private IPermissionsService _permissionsService;

        public PermissionsController(IPermissionsService permissionsService)
        {
            _permissionsService = permissionsService;
        }

        [HttpGet("GetAll")]
        public List<Permissions> GetAll()
        {
            return _permissionsService.GetAll();
        }

        [HttpGet("GetById")]
        public Permissions GetById(int id)
        {
            return _permissionsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Permissions _permissionsFormData)
        {
            Permissions _permissions = new Permissions();

            _permissionsService.Add(_permissions);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Permissions _permissionsFormData)
        {
            Permissions _permissions = new Permissions();

            _permissionsService.Update(_permissions);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _permissionsService.Delete(_permissionsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByPermissionTypeId")] // Foreign key tablo servis   api/<controller>/GetListByPermissionsID/1
        public List<Permissions> GetListByPermissionTypeId(int permissiontypeid)
        {
            return _permissionsService.GetListByPermissionTypeId(permissiontypeid);
        }

        [HttpGet("GetListByRoleId")] // Foreign key tablo servis   api/<controller>/GetListByPermissionsID/1
        public List<Permissions> GetListByRoleId(int roleid)
        {
            return _permissionsService.GetListByRoleId(roleid);
        }

        [HttpGet("GetListByUserId")] // Foreign key tablo servis   api/<controller>/GetListByPermissionsID/1
        public List<Permissions> GetListByUserId(int userid)
        {
            return _permissionsService.GetListByUserId(userid);
        }
    }
}