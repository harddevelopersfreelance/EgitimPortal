using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class ExamQuestionMap : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int ExamId { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual string QuestionWeigth { get; set; }
    }
}