using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditLogsController : ControllerBase
    {
        private IAuditLogsService _auditlogsService;

        public AuditLogsController(IAuditLogsService auditlogsService)
        {
            _auditlogsService = auditlogsService;
        }

        [HttpGet("GetAll")]
        public List<AuditLogs> GetAll()
        {
            return _auditlogsService.GetAll();
        }

        [HttpGet("GetById")]
        public AuditLogs GetById(int id)
        {
            return _auditlogsService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] AuditLogs _auditlogsFormData)
        {
            AuditLogs _auditlogs = new AuditLogs();
            //
            _auditlogsService.Add(_auditlogs);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] AuditLogs _auditlogsFormData)
        {
            AuditLogs _auditlogs = new AuditLogs();
            //
            _auditlogsService.Update(_auditlogs);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _auditlogsService.Delete(_auditlogsService.GetById(id));
            //Duruma gore yazılacak
        }

        [HttpGet("GetListByUserId")] // Foreign key tablo servis   api/<controller>/GetListByAuditLogsID/1
        public List<AuditLogs> GetListByUserId(int userid)
        {
            return _auditlogsService.GetListByUserId(userid);
        }
    }
}