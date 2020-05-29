using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IExamQuestionMapService
    {
        List<ExamQuestionMap> GetAll();

        ExamQuestionMap GetById(int id);

        ExamQuestionMap Add(ExamQuestionMap examquestionmap);

        ExamQuestionMap Update(ExamQuestionMap examquestionmap);

        void Delete(ExamQuestionMap examquestionmap);

        List<ExamQuestionMap> GetListByExamID(int examid);

        List<ExamQuestionMap> GetListByQuestionID(int questionid);
    }
}