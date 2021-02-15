using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class GenderValidatior : AbstractValidator<Gender>
    {
        public GenderValidatior()
        {
        }
    }
}