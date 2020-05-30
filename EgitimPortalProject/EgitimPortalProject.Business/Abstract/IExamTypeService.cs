using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IExamTypeService
    {
        List<ExamType> GetAll();

        ExamType GetById(int id);

        ExamType Add(ExamType examtype);

        ExamType Update(ExamType examtype);

        void Delete(ExamType examtype);
    }
}