using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class CoursesValidatior : AbstractValidator<Courses>
    {
        public CoursesValidatior()
        {
        }
    }
}