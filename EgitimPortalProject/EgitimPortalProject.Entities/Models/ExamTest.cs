using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class ExamTest : AuditableEntityBase, IEntity
    {
        public virtual string ExamTestName { get; set; }
    }
}