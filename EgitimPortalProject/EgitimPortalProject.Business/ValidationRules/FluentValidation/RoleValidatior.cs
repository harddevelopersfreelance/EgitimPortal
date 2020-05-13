using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation; 

namespace EgitimPortalProject.Business.ValidationRules.FluentValidation
{
    public class RoleValidatior : AbstractValidator<Role>
    {
        public RoleValidatior()
        {
        }
    }
}