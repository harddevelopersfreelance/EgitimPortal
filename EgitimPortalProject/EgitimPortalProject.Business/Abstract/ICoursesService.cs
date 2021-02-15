using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ICoursesService
    {
        List<Courses> GetAll();

        Courses GetById(int id);

        Courses Add(Courses courses);

        Courses Update(Courses courses);

        void Delete(Courses courses);
    }
}