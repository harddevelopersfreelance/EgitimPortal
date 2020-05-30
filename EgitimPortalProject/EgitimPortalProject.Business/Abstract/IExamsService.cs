using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IExamsService
    {
        List<Exams> GetAll();

        Exams GetById(int id);

        Exams Add(Exams exams);

        Exams Update(Exams exams);

        void Delete(Exams exams);

        List<Exams> GetListByExamTypeId(int examtypeid);
    }
}