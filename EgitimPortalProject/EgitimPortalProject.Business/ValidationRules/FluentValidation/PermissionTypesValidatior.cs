using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class PermissionTypesValidatior : AbstractValidator<PermissionTypes>
    {
        public PermissionTypesValidatior()
        {
        }
    }
}