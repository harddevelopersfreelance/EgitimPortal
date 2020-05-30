using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class StudentCourseWatchLogValidatior : AbstractValidator<StudentCourseWatchLog>
    {
        public StudentCourseWatchLogValidatior()
        {
        }
    }
}