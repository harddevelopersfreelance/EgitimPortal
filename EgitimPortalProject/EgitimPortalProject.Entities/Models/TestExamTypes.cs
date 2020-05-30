using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class TestExamTypes : AuditableEntityBase, IEntity
    {
        public virtual string TestTypeName { get; set; }
    }
}