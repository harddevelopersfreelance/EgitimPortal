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

        List<QuestionOptionsMap> GetListByQuestionID(int questionid);

        List<QuestionOptionsMap> GetListByOptionID(int optionid);
    }
}