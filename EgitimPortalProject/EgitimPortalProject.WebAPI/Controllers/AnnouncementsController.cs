using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {
        private IAnnouncementsService _announcementsService;

        public AnnouncementsController(IAnnouncementsService announcementsService)
        {
            _announcementsService = announcementsService;
        }

        [HttpGet("GetAll")]
        public List<Announcements> GetAll()
        {
            return _announcementsService.GetAll();
        }

        [HttpGet("GetById")]
        public Announcements GetById(int id)
        {
            return _announcementsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Announcements _announcementsFormData)
        {
            Announcements _announcements = new Announcements();

            _announcementsService.Add(_announcements);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Announcements _announcementsFormData)
        {
            Announcements _announcements = new Announcements();

            _announcementsService.Update(_announcements);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _announcementsService.Delete(_announcementsService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}