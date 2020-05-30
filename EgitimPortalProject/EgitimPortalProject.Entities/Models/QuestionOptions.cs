using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionOptions : AuditableEntityBase, IEntity
    {
        public virtual int QuestionOptionTypeId { get; set; }
        public virtual string ImageRoot { get; set; }

        //public virtual string ImageId { get; set; }
        public virtual bool isCorrect { get; set; }

        public virtual string QuestionOptionValue { get; set; }
    }
}