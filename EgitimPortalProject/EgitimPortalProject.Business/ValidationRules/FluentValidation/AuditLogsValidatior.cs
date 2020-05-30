using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class AuditLogsValidatior : AbstractValidator<AuditLogs>
    {
        public AuditLogsValidatior()
        {
        }
    }
}