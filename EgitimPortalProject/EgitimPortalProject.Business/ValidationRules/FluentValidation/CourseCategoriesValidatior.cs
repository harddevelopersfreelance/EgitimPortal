using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class CourseCategoriesValidatior : AbstractValidator<CourseCategories>
    {
        public CourseCategoriesValidatior()
        {
        }
    }
}