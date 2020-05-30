using EgitimPortalProject.Business.Abstract;
using EgitimPortalProject.Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _usersService;

        public UsersController(IUserService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("GetAll")]
        public List<Users> GetAll()
        {
            return _usersService.GetAll();
        }

        [HttpGet("GetById")]
        public Users GetById(int id)
        {
            return _usersService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Users _usersFormData)
        {
            Users _users = new Users();
            //
            _usersService.Add(_users);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Users _usersFormData)
        {
            Users _users = new Users();
            //
            _usersService.Update(_users);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _usersService.Delete(_usersService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByGenderId")] // Foreign key tablo servis   api/<controller>/GetListByUsersID/1
        public List<Users> GetListByGenderId(int genderid)
        {
            return _usersService.GetListByGenderId(genderid);
        }

        [HttpGet("GetListByLanguageId")] // Foreign key tablo servis   api/<controller>/GetListByUsersID/1
        public List<Users> GetListByLanguageId(int languageid)
        {
            return _usersService.GetListByLanguageId(languageid);
        }
    }
}