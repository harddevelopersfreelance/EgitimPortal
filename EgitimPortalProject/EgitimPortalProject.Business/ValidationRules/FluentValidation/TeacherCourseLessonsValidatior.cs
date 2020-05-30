using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class TeacherCourseLessonsValidatior : AbstractValidator<TeacherCourseLessons>
    {
        public TeacherCourseLessonsValidatior()
        {
        }
    }
}