using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class LanguageText : IEntity
    {
        public virtual int id { get; set; }
        public virtual string LanguageName { get; set; }
        public virtual string Source { get; set; }
        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
    }
}