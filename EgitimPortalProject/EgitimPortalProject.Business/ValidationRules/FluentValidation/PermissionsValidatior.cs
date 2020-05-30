using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class PermissionsValidatior : AbstractValidator<Permissions>
    {
        public PermissionsValidatior()
        {
        }
    }
}