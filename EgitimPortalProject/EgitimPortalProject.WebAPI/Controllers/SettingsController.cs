using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private ISettingsService _settingsService;

        public SettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet("GetAll")]
        public List<Settings> GetAll()
        {
            return _settingsService.GetAll();
        }

        [HttpGet("GetById")]
        public Settings GetById(int id)
        {
            return _settingsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Settings _settingsFormData)
        {
            Settings _settings = new Settings();

            _settingsService.Add(_settings);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Settings _settingsFormData)
        {
            Settings _settings = new Settings();

            _settingsService.Update(_settings);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _settingsService.Delete(_settingsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByUserId")] // Foreign key tablo servis   api/<controller>/GetListBySettingsID/1
        public List<Settings> GetListByUserId(int userid)
        {
            return _settingsService.GetListByUserId(userid);
        }

        [HttpGet("GetListByRoleId")] // Foreign key tablo servis   api/<controller>/GetListBySettingsID/1
        public List<Settings> GetListByRoleId(int roleid)
        {
            return _settingsService.GetListByRoleId(roleid);
        }
    }
}