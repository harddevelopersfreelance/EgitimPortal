using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IExamTestService
    {
        List<ExamTest> GetAll();

        ExamTest GetById(int id);

        ExamTest Add(ExamTest examtest);

        ExamTest Update(ExamTest examtest);

        void Delete(ExamTest examtest);
    }
}