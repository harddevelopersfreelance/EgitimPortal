using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class StudentCoursesValidatior : AbstractValidator<StudentCourses>
    {
        public StudentCoursesValidatior()
        {
        }
    }
}