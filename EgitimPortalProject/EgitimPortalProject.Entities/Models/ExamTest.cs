using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class ExamTest : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string ExamTestName { get; set; }
    }
}