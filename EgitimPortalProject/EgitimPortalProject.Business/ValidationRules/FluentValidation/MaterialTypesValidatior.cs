using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class MaterialTypesValidatior : AbstractValidator<MaterialTypes>
    {
        public MaterialTypesValidatior()
        {
        }
    }
}