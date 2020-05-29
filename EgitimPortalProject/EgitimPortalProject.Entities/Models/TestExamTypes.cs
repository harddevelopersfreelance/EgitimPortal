using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class TestExamTypes : IEntity
    {
        public virtual int TestTypeId { get; set; }
        public virtual string TestTypeName { get; set; }
    }
}