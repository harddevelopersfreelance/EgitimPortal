using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class SettingsValidatior : AbstractValidator<Settings>
    {
        public SettingsValidatior()
        {
        }
    }
}