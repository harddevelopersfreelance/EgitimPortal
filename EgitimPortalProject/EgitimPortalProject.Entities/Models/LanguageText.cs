using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class LanguageText : AuditableEntityBase, IEntity
    {
        public virtual string LanguageName { get; set; }
        public virtual string Source { get; set; }
        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
    }
}