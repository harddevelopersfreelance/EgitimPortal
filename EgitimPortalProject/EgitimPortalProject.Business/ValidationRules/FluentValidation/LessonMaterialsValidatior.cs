using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class LessonMaterialsValidatior : AbstractValidator<LessonMaterials>
    {
        public LessonMaterialsValidatior()
        {
        }
    }
}