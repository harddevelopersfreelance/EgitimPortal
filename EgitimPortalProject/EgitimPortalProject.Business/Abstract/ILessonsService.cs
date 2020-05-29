using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ILessonsService
    {
        List<Lessons> GetAll();

        Lessons GetById(int id);

        Lessons Add(Lessons lessons);

        Lessons Update(Lessons lessons);

        void Delete(Lessons lessons);
    }
}