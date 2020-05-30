using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class LanguageValidatior : AbstractValidator<Language>
    {
        public LanguageValidatior()
        {
        }
    }
}