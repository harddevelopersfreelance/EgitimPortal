using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IQuestionOptionTypesService
    {
        List<QuestionOptionTypes> GetAll();

        QuestionOptionTypes GetById(int id);

        QuestionOptionTypes Add(QuestionOptionTypes questionoptiontypes);

        QuestionOptionTypes Update(QuestionOptionTypes questionoptiontypes);

        void Delete(QuestionOptionTypes questionoptiontypes);
    }
}