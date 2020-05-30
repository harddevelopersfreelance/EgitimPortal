using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class CategoriesValidatior : AbstractValidator<Categories>
    {
        public CategoriesValidatior()
        {
        }
    }
}