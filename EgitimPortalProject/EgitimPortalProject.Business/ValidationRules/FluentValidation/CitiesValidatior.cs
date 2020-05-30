using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class CitiesValidatior : AbstractValidator<Cities>
    {
        public CitiesValidatior()
        {
        }
    }
}