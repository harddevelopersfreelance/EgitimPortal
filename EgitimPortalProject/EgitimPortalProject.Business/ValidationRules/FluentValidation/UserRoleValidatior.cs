using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation;

namespace EgitimPortalProject.Business.ValidationRules.FluentValidation
{
    public class UserRoleValidatior : AbstractValidator<UserRoles>
    {
        public UserRoleValidatior()
        {
        }
    }
}