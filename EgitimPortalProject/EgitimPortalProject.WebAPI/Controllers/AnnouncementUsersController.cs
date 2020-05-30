using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementUsersController : ControllerBase
    {
        private IAnnouncementUsersService _announcementusersService;

        public AnnouncementUsersController(IAnnouncementUsersService announcementusersService)
        {
            _announcementusersService = announcementusersService;
        }

        [HttpGet("GetAll")]
        public List<AnnouncementUsers> GetAll()
        {
            return _announcementusersService.GetAll();
        }

        [HttpGet("GetById")]
        public AnnouncementUsers GetById(int id)
        {
            return _announcementusersService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] AnnouncementUsers _announcementusersFormData)
        {
            AnnouncementUsers _announcementusers = new AnnouncementUsers();

            _announcementusersService.Add(_announcementusers);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] AnnouncementUsers _announcementusersFormData)
        {
            AnnouncementUsers _announcementusers = new AnnouncementUsers();

            _announcementusersService.Update(_announcementusers);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _announcementusersService.Delete(_announcementusersService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByAnnouncementId")]
        public List<AnnouncementUsers> GetListByAnnouncementId(int announcementid)
        {
            return _announcementusersService.GetListByAnnouncementId(announcementid);
        }

        [HttpGet("GetListByUserId")]
        public List<AnnouncementUsers> GetListByUserId(int userid)
        {
            return _announcementusersService.GetListByUserId(userid);
        }
    }
}