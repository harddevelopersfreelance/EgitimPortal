using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IGenderService
    {
        List<Gender> GetAll();

        Gender GetById(int id);

        Gender Add(Gender gender);

        Gender Update(Gender gender);

        void Delete(Gender gender);
    }
}