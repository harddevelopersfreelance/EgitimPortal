using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class UserRolesValidatior : AbstractValidator<UserRoles>
    {
        public UserRolesValidatior()
        {
            RuleFor(p => p.UserId).NotEmpty().WithMessage("Boş Geçilemez !!!");
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("Boş Geçilemez !!!");
        }
    }
}