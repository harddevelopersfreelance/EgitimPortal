using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class LessonCategoriesValidatior : AbstractValidator<LessonCategories>
    {
        public LessonCategoriesValidatior()
        {
        }
    }
}