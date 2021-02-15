using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IStudentsService
    {
        List<Students> GetAll();

        Students GetById(int id);

        Students Add(Students students);

        Students Update(Students students);

        void Delete(Students students);
    }
}