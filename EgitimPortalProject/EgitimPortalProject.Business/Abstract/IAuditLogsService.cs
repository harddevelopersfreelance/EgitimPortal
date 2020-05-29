using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IAuditLogsService
    {
        List<AuditLogs> GetAll();

        AuditLogs GetById(int id);

        AuditLogs Add(AuditLogs auditlogs);

        AuditLogs Update(AuditLogs auditlogs);

        void Delete(AuditLogs auditlogs);

        List<AuditLogs> GetListByUserID(int userid);
    }
}