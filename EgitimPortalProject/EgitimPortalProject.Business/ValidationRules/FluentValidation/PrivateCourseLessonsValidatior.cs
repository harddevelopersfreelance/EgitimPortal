using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class PrivateCourseLessonsValidatior : AbstractValidator<PrivateCourseLessons>
    {
        public PrivateCourseLessonsValidatior()
        {
        }
    }
}