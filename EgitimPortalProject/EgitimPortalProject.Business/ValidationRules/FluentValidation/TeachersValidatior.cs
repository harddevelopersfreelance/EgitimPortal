using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class TeachersValidatior : AbstractValidator<Teachers>
    {
        public TeachersValidatior()
        {
        }
    }
}