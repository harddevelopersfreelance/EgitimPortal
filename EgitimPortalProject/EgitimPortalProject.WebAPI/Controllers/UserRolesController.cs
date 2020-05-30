using EgitimPortal.Business.Abstract;
using EgitimPortalProject.Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private IUserRolesService _userrolesService;

        public UserRolesController(IUserRolesService userrolesService)
        {
            _userrolesService = userrolesService;
        }

        [HttpGet("GetAll")]
        public List<UserRoles> GetAll()
        {
            return _userrolesService.GetAll();
        }

        [HttpGet("GetById")]
        public UserRoles GetById(int id)
        {
            return _userrolesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] UserRoles _userrolesFormData)
        {
            UserRoles _userroles = new UserRoles();

            _userrolesService.Add(_userroles);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] UserRoles _userrolesFormData)
        {
            UserRoles _userroles = new UserRoles();

            _userrolesService.Update(_userroles);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _userrolesService.Delete(_userrolesService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByUserId")] // Foreign key tablo servis   api/<controller>/GetListByUserRolesID/1
        public List<UserRoles> GetListByUserId(int userid)
        {
            return _userrolesService.GetListByUserId(userid);
        }

        [HttpGet("GetListByRoleIdId")] // Foreign key tablo servis   api/<controller>/GetListByUserRolesID/1
        public List<UserRoles> GetListByRoleIdId(int operationclaimid)
        {
            return _userrolesService.GetListByRoleIdId(operationclaimid);
        }
    }
}