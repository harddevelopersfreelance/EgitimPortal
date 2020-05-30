using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ITeachersService
    {
        List<Teachers> GetAll();

        Teachers GetById(int id);

        Teachers Add(Teachers teachers);

        Teachers Update(Teachers teachers);

        void Delete(Teachers teachers);
    }
}