using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class CourseTeachersValidatior : AbstractValidator<CourseTeachers>
    {
        public CourseTeachersValidatior()
        {
        }
    }
}