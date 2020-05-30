using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class LanguageTextValidatior : AbstractValidator<LanguageText>
    {
        public LanguageTextValidatior()
        {
        }
    }
}