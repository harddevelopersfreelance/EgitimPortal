using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class StudentsValidatior : AbstractValidator<Students>
    {
        public StudentsValidatior()
        {
        }
    }
}