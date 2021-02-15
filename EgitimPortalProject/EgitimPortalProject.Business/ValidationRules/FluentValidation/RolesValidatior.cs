using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class RolesValidatior : AbstractValidator<Roles>
    {
        public RolesValidatior()
        {
            RuleFor(p => p.RoleName).NotEmpty().WithMessage("Boş Geçilemez !!!");
        }
    }
}