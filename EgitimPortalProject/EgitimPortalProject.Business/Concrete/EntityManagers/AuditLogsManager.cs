using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class AuditLogsManager : IAuditLogsService
    {
        private IAuditLogsDal _auditlogsDal;
        private readonly IMapper _mapper;

        public AuditLogsManager(IAuditLogsDal auditlogsDal, IMapper mapper)
        {
            _auditlogsDal = auditlogsDal;
            _mapper = mapper;
        }

        public List<AuditLogs> GetAll()
        {
            var model = _mapper.Map<List<AuditLogs>>(_auditlogsDal.GetList());
            return model;
        }

        public AuditLogs GetById(int id)
        {
            var model = _auditlogsDal.Get(p => p.Id == id);
            return model;
        }

        public AuditLogs Add(AuditLogs auditlogs)
        {
            return _auditlogsDal.Add(auditlogs);
        }

        public AuditLogs Update(AuditLogs auditlogs)
        {
            return _auditlogsDal.Update(auditlogs);
        }

        public void Delete(AuditLogs auditlogs)
        {
            _auditlogsDal.Delete(auditlogs);
        }

        /// Tablosu ile olan Foreign Key Column UserId
        public List<AuditLogs> GetListByUserId(int userid)
        {
            var model = _auditlogsDal.GetList(p => p.UserId == userid);
            return model;
        }
    }
}