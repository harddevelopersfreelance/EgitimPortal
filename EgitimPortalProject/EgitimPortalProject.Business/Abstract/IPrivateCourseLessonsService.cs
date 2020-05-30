using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IPrivateCourseLessonsService
    {
        List<PrivateCourseLessons> GetAll();

        PrivateCourseLessons GetById(int id);

        PrivateCourseLessons Add(PrivateCourseLessons privatecourselessons);

        PrivateCourseLessons Update(PrivateCourseLessons privatecourselessons);

        void Delete(PrivateCourseLessons privatecourselessons);
    }
}