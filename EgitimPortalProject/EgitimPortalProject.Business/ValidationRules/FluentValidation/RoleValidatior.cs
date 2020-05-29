using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation; 

namespace EgitimPortalProject.Business.ValidationRules.FluentValidation
{
    public class RoleValidatior : AbstractValidator<Roles>
    {
        public RoleValidatior()
        {
        }
    }
}