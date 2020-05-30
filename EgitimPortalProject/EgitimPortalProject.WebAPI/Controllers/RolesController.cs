using EgitimPortal.Business.Abstract;
using EgitimPortalProject.Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private IRolesService _rolesService;

        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        [HttpGet("GetAll")]
        public List<Roles> GetAll()
        {
            return _rolesService.GetAll();
        }

        [HttpGet("GetById")]
        public Roles GetById(int id)
        {
            return _rolesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Roles _rolesFormData)
        {
            Roles _roles = new Roles();

            _rolesService.Add(_roles);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Roles _rolesFormData)
        {
            Roles _roles = new Roles();

            _rolesService.Update(_roles);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _rolesService.Delete(_rolesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}