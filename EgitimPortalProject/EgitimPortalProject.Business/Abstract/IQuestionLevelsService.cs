using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IQuestionLevelsService
    {
        List<QuestionLevels> GetAll();

        QuestionLevels GetById(int id);

        QuestionLevels Add(QuestionLevels questionlevels);

        QuestionLevels Update(QuestionLevels questionlevels);

        void Delete(QuestionLevels questionlevels);
    }
}