using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IQuestionOptionsMapService
    {
        List<QuestionOptionsMap> GetAll();

        QuestionOptionsMap GetById(int id);

        QuestionOptionsMap Add(QuestionOptionsMap questionoptionsmap);

        QuestionOptionsMap Update(QuestionOptionsMap questionoptionsmap);

        void Delete(QuestionOptionsMap questionoptionsmap);

        List<QuestionOptionsMap> GetListByQuestionId(int questionid);

        List<QuestionOptionsMap> GetListByOptionId(int optionid);
    }
}