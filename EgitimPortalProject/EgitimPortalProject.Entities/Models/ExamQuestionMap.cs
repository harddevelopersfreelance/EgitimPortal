using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class ExamQuestionMap : AuditableEntityBase, IEntity
    {
        public virtual int ExamId { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual string QuestionWeigth { get; set; }
    }
}