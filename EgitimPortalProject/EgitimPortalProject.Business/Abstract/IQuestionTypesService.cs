using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IQuestionTypesService
    {
        List<QuestionTypes> GetAll();

        QuestionTypes GetById(int id);

        QuestionTypes Add(QuestionTypes questiontypes);

        QuestionTypes Update(QuestionTypes questiontypes);

        void Delete(QuestionTypes questiontypes);
    }
}