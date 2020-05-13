using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation;

namespace EgitimPortalProject.Business.ValidationRules.FluentValidation
{
    public class UserRoleValidatior : AbstractValidator<UserRole>
    {
        public UserRoleValidatior()
        {
        }
    }
}